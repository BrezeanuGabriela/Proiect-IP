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

        public void PreiaComanda(IComanda comanda, int indexMasa)
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
            masa.AddComanda(comanda);
        }

        public String EmiteBon(int indexMasa, int indexComandaSelectata)
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
            Comanda comanda = null;
            masa.GetComanda(indexComandaSelectata, ref comanda);

            return comanda.TiparesteBon();
        }

        public double InchideCasa()
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(0);
            return masa.TotalCostComenziMasa();
        }

    }
}
