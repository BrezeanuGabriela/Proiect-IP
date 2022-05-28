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
            if (indexMasa < SalaRestaurant.Instance().ListaMese.Count)
            {
                IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
                if (masa != null)
                {
                    masa.AddComanda(comanda);
                }
                else
                {
                    throw new Exception("Nu exista vreo masa");
                }
            }
            else
            {
                throw new Exception("Indexul mesei este prea mare.");
            }
        }

        public String EmiteBon(int indexMasa, int indexComandaSelectata)
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
            if (masa != null)
            {
                Comanda comanda = null;
                masa.GetComanda(indexComandaSelectata, ref comanda);

                return comanda.TiparesteBon();
            }
            return "";
        }

        public double InchideCasa()
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(0);
            return masa.TotalCostComenziMasa();
        }

    }
}
