using System;
using System.Collections.Generic;

namespace Restaurant
{
    public abstract class IMasa
    {
        protected List<Comanda> _comenzi;
        public List<Comanda> Comenzi
        {
            get { return _comenzi; }
        }
        protected int index;
        protected static int _nrMese = 0;
        
        public abstract void AddComanda(Comanda comanda);

        public abstract Comanda GetComanda(int index);

        public abstract void StergeComanda(Comanda comanda);

        public abstract double TotalCostComenziMasa();
    }
}