﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant;

namespace InterfataRestaurant
{
    public partial class GUIRestaurant : Form
    {
        private SalaRestaurant _salaRestaurant;
        private Chelner _chelner;
        private Client _client;
        private Meniu _meniu; 
        private IMasa _masa;
        private List<Produs> _produseMeniu;
        private List<Produs> _produseSelectate;
        private double _cost;
        private int _idClient;

        /// <summary>
        /// Constructorul interfetei grafice
        /// </summary>
        public GUIRestaurant()
        {
            InitializeComponent();

            citesteProduse();
            _meniu = Meniu.InstantaMeniu(_produseMeniu);
            _produseSelectate = new List<Produs>();

            mancareClient.Items.Clear();
            foreach(Produs produs in _produseMeniu)
            {
                mancareClient.Items.Add(produs.AfisareProdus());
            }

            _salaRestaurant = SalaRestaurant.Instance();
            _masa = new Masa();
            _salaRestaurant.AddTable(_masa);

            _chelner = Chelner.Instance();
            _cost = 0;
            _idClient = 0;

            emiteBon.Enabled = false;
        }
        
        /// <summary>
        /// Metoda folosita pentru a citi produsele dintr-un fisier, iar apoi le adauga in meniu
        /// </summary>
        private void citesteProduse()
        {
            //citim din fisier produsele
            try
            {
                StreamReader sr = new StreamReader("produse.txt");
                String continutProduse = sr.ReadToEnd();
                sr.Close();

                //parsam datele extrase din fisier
                String[] produse = continutProduse.Split('\n');
                _produseMeniu = new List<Produs>();

                foreach (String produs in produse)
                {
                    String[] elementeProdus = produs.Split('/');

                    String denumire = elementeProdus[0];
                    double pret = Double.Parse(elementeProdus[1]);
                    String[] ingrediente = elementeProdus[2].Split('+');

                    List<String> listaIngrediente = new List<String>();
                    foreach (String ingredient in ingrediente)
                    {
                        listaIngrediente.Add(ingredient);
                    }

                    //se adauga produsul in meniu
                    _produseMeniu.Add(new Produs(denumire, pret, listaIngrediente));
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Fisiserul cu produse nu a fost gasit!", "Eroare aplicatie");
                //ar trebui sa se inchida aplicatia?
            }
        }

        /// <summary>
        /// Metoda folosita pentru a adauga produsul selectat de client intr-o lista cu toate produsele din comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adaugaMancareClient_Click(object sender, EventArgs e)
        {
            try
            {
                int indexProdusSelectat = mancareClient.SelectedIndex;
                _produseSelectate.Add(_produseMeniu[indexProdusSelectat]);
                _cost += _produseMeniu[indexProdusSelectat].Pret;
                textTotalClient.Text = _cost.ToString();
                bonClient.Items.Add(_produseMeniu[indexProdusSelectat].AfisareProdus());
            }
            catch(Exception exception)
            {
                MessageBox.Show("Selectati un produs mai intai!", "Eroare client");
            }
        }

        /// <summary>
        /// Metoda folosita pentru a sterge produsul selectat de client din lista cu toate produsele din comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stergeProdusClient_Click(object sender, EventArgs e)
        {
            try
            {
                int indexProdusSelectat = bonClient.SelectedIndex;
                _produseSelectate.Remove(_produseSelectate[indexProdusSelectat]);
                _cost -= _produseMeniu[indexProdusSelectat].Pret;
                textTotalClient.Text = _cost.ToString();
                bonClient.Items.Remove(bonClient.SelectedItem);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Nu ati selectat niciun produs pentru a-l sterge!", "Eroare client");
            }
        }

        /// <summary>
        /// Metoda folosita pentru a crea comanda cu produsele selectate de client si o trimite la chelner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trimiteComandaClient_Click(object sender, EventArgs e)
        {
            if (_produseSelectate.Count > 0)
            {
                _idClient += 1;

                _client = new Client(_idClient, 0);

                foreach(Produs produs in _produseSelectate)
                {
                    _client.AdaugaProdus(produs);
                }

                //trimite comanda la client
                String observatii = observatiiClient.Text;
                _client.Observatii = observatii;
                _client.TrimiteComanda();

                //adauga comanda in lista comenzilor de la chelner
                int nrComenzi = _salaRestaurant.GetComenziMasaCurenta().Count;

                listaComenziChelner.Items.Add(((Comanda)_salaRestaurant.GetComenziMasaCurenta()[nrComenzi-1]).GetRezumatComanda());

                //"curata" panoul clientului
                bonClient.Items.Clear();
                mancareClient.SelectedIndex = -1;
                observatiiClient.Text = "";
                textTotalClient.Text = "";

                _produseSelectate = new List<Produs>();
                _cost = 0;
            }
            else
            {
                MessageBox.Show("Nu ati selectat niciun produs pentru a emite o comanda!", "Eroare client");
            }
        }

        /// <summary>
        /// Metoda folosita pentru a afisa detaliile comenzii selectate de chelner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaComenziChelner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //preluam comanda
                int indexComandaSelectata = listaComenziChelner.SelectedIndex;
                Comanda comanda = null;

                _masa.GetComanda(indexComandaSelectata, ref comanda);

                //afisam informatiile
                detaliiComandaChelner.Text = comanda.AfiseazaComanda();
                observatiiChelner.Text = comanda.Observatii;
                
                //daca inca nu are vreun bon emis inca, activam butonul de emite bon
                if(comanda.Finalizata == false)
                {
                    emiteBon.Enabled = true;
                }
                else
                {
                    emiteBon.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Selectati mai intai comanda pentru care doriti sa emiteti bonul!", "Eroare chelner");
            }
        }

        /// <summary>
        /// Metoda folosita pentru a emite bonul fiscal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emiteBon_Click(object sender, EventArgs e)
        {
            try
            {
                int indexComandaSelectata = listaComenziChelner.SelectedIndex;

                Comanda comanda = null;
                //preluam comanda selectata
                _masa.GetComanda(indexComandaSelectata, ref comanda);

                //afisam bonul
                MessageBox.Show(_chelner.EmiteBon(0, indexComandaSelectata));

                //stergem produsele selectate de client
                bonClient.Items.Clear();
                _produseSelectate = new List<Produs>();
                textTotalClient.Text = "";

                //Dezactivam butonul pentru comanda curenta, deoarece am emis bonul
                emiteBon.Enabled = false;
                detaliiComandaChelner.Text = comanda.AfiseazaComanda();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Selectati mai intai comanda pentru care doriti sa emiteti bonul!", "Eroare chelner");
            }
        }

        private void inchideCasa_Click(object sender, EventArgs e)
        {
            //double costTotalComenzi = _masa.TotalCostComenziMasa();
            double costTotalComenzi = _chelner.InchideCasa();
            if (costTotalComenzi == 0.0)
            {
                MessageBox.Show("Nu au fost inregistrare inca comenzi!", "Total comenzi");
                return;
            }
            else if(costTotalComenzi < 0.0)
            {
                MessageBox.Show("Nu au fost emise bonuri pentru toate comenzile! Comanda " + (-costTotalComenzi).ToString() + 
                    " nu are inca bonul emis!", "Total comenzi");
                return;
            }
            else
            {
                MessageBox.Show("Suma totala incasata din comenzi: " + costTotalComenzi.ToString() + " lei", "Total comenzi");
            }

            //lista auxiliara utilizata pentru stergerea comenzilor
            //fara ea ar fi aparut conflicte in listaComenziChelner pentru ca acolo comenzile se preiau direct din comenzile de pe masa, iar noi daca umblam
            //la lista respectiva dinamica(adica cea de la masa), vor aparea erori in momentul in care se incearca sa se preia o comanda care a fost stearsa anterior
            List<Comanda> listaAuxiliaraComenzi = new List<Comanda>();
            foreach(Comanda comanda in _masa.Comenzi)
            {
                listaAuxiliaraComenzi.Add(comanda);
            }

            //stergem comenzile
            foreach(Comanda comanda in listaAuxiliaraComenzi)
            {
                _masa.StergeComanda(comanda);
            }

            //actualizam interfata
            listaComenziChelner.Items.Clear();
            detaliiComandaChelner.Text = "";
            bonClient.Items.Clear();

            //eliberam memoria folosita
            listaAuxiliaraComenzi.Clear();
        }
    }
}
