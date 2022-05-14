using System;

namespace Restaurant
{
    public abstract class IComanda
    {
        protected int _idClient;
        protected int _idComanda;

        protected static int _nrComenzi = 0;

        public abstract double Facturare();

        public abstract String AfiseazaComanda();
    }
}

