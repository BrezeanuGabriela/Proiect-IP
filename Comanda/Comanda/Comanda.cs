using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Comanda : IComanda
    {
        protected List<Produs> _produseComandate;
        protected double _costTotal;
        protected bool _finalizata;

        public bool Finalizata
        {
            get { return _finalizata;  }
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
        public Comanda(int idClient, List<Produs> produse)
        {
            _idClient = idClient;

            _idComanda = _nrComenzi;
            _nrComenzi++;

            _produseComandate = produse;
            
            _costTotal = 0;
        }

        public override double Facturare()
        {
            foreach(Produs produs in _produseComandate)
            {
                //_costTotal += produs.getPrice();
            }

            _finalizata = true;
             return _costTotal;
        }

        public override String AfiseazaComanda()
        {
            string comanda = "";
            comanda += "Comanda cu id-ul " + this._idComanda.ToString() + " la clientul " + this._idClient.ToString() + ":\n";
            
            foreach(Produs produs in _produseComandate)
            {
                //comanda += produs.getDenumire() + " - " + produs.getPrice() + "\n";
            }

            comanda += "----------------\n Cost Total: " + _costTotal.ToString();

            return comanda;
        }
    }
}
