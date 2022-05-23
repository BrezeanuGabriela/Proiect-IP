using System;

namespace Restaurant
{
    public abstract class IComanda
    {
        public abstract double Facturare();

        public abstract String AfiseazaComanda();

        public abstract String TiparesteBon();
    }
}

