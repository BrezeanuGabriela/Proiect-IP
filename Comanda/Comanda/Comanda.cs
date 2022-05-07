using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Comanda
    {
        private int _idClient;
        private int _idComanda;
        private List<Produs> _produseComandate;
        private double _costTotal;
        public abstract double Facturare();

        public abstract String AfiseazaComanda();
    }
}
