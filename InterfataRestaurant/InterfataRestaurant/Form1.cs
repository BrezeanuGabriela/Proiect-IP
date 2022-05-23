using System;
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
        private Meniu _meniu; 
        //daca tot avem un meniu cred ca ar fi mai ok ca atunci cand vreau sa ma folosesc de un produs din el, sa aiba un getter implementat
        private IMasa _masa;
        private List<Produs> _produseMeniu;
        private List<Produs> _produseSelectate;
        private double _cost;
        private int _idClient;
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

            _masa = new Masa();
            _cost = 0;
            _idClient = 0;
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
                String observatii = observatiiClient.Text;
                Comanda comanda = new Comanda(_idClient, _produseSelectate, observatii);
                _masa.AddComanda(comanda);
                listaComenziChelner.Items.Add(comanda.GetRezumatComanda());
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
                Comanda comanda = _masa.GetComanda(indexComandaSelectata);
                //afisam informatiile
                detaliiComandaChelner.Text = comanda.AfiseazaComanda();
                observatiiChelner.Text = comanda.Observatii;
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
                IComanda comanda = _masa.GetComanda(indexComandaSelectata);
                MessageBox.Show(comanda.TiparesteBon());
                bonClient.Items.Clear();
                _produseSelectate = new List<Produs>();
                textTotalClient.Text = "";
            }
            catch(Exception exception)
            {
                MessageBox.Show("Selectati mai intai comanda pentru care doriti sa emiteti bonul!", "Eroare chelner");
            }
        }
    }
}
