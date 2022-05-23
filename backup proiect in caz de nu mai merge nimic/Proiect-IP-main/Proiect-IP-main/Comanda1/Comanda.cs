using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Comanda : IComanda
    {
        protected int _idClient;
        protected int _idComanda;
        protected String _observatii;

        protected static int _nrComenzi = 0;

        protected List<Produs> _produseComandate;
        protected double _costTotal;
        protected bool _finalizata;

        public String Observatii
        {
            get { return _observatii; }
        }
        public bool Finalizata
        {
            get { return _finalizata; }
            set { _finalizata = value; }
        }
        public double CostTotal
        {
            get { return _costTotal; }
        }

        public int IdClient
        {
            get { return _idClient; }
        }
        public Comanda(int idClient, List<Produs> produse, String observatii)
        {
            _idClient = idClient;

            _nrComenzi++;
            _idComanda = _nrComenzi;
            
            _produseComandate = produse;

            _observatii = observatii;
            _costTotal = 0;
        }

        public override double Facturare()
        {
            foreach (Produs produs in _produseComandate)
            {
                _costTotal += produs.Pret;
            }

            _finalizata = true;
            return _costTotal;
        }

        public override String AfiseazaComanda()
        {
            string comanda = "";
            comanda += "Comanda cu id-ul " + this._idComanda.ToString() + " la clientul " + this._idClient.ToString() + System.Environment.NewLine;

            foreach (Produs produs in _produseComandate)
            {
                comanda += produs.Denumire + " - " + produs.Pret + System.Environment.NewLine + " lei";
            }

            Double cost = this.Facturare();
            comanda += System.Environment.NewLine + "Cost Total: " + cost.ToString();

            if(_observatii != "")
            {
                comanda += _observatii + System.Environment.NewLine;
            }
            return comanda;
        }

        public String GetRezumatComanda()
        {
            return "Comanda " + this._idComanda.ToString();
        }

        public override String TiparesteBon()
        {
            string bon = "";
            bon += "ID comanda: " + this._idComanda.ToString() + System.Environment.NewLine;
            bon += "Produse comandate: " + System.Environment.NewLine;

            foreach (Produs produs in _produseComandate)
            {
                bon += produs.Denumire + " - " + produs.Pret + " lei" + System.Environment.NewLine;
            }

            bon += System.Environment.NewLine + "Cost Total: " + _costTotal.ToString() + " lei";

            if (_observatii != "")
            {
                bon += System.Environment.NewLine + _observatii + System.Environment.NewLine;
            }

            bon += System.Environment.NewLine + "Va multumim pentru ca ati mancat la noi si va mai asteptam!";

            return bon;
        }
    }
}
