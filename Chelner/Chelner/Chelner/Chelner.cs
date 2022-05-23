using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public sealed class Chelner
    {
        private static Chelner _instance;

        private Chelner()
        {

        }

        public static Chelner Instance()
        {
            if (_instance == null)
            {
                _instance = new Chelner();
            }
            return _instance;
        }

        public void PreiaComanda(Comanda comanda, int indexMasa)
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
            masa.AddComanda(comanda);
        }



        public double EmiteBon(int indexMasa, int idClient)
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
            double costTotal = 0;
            foreach (Comanda comanda in masa.Comenzi)
            {
                if (comanda.IdClient == idClient)
                {
                    costTotal += comanda.CostTotal;
                }
            }
            return costTotal;
        }

        //daca s-ar sterge comanda cum mai inchid casa?
        public double InchideCasa()
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(0);
            return masa.TotalCostComenziMasa();
        }

    }
}
