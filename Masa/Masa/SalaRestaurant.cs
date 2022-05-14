using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public sealed class SalaRestaurant
    {
        private static SalaRestaurant _instance;

        private List<IMasa> _listaMese;
        private int _indexMasaCurenta;
        private SalaRestaurant()
        {
            _listaMese = new List<IMasa>();
        }

        public SalaRestaurant Instance()
        {
            if( null == _instance)
            {
                _instance = new SalaRestaurant();
            }
            return _instance;
        }
        public IMasa GetCurrentTable(int indexMasa)
        {
            _indexMasaCurenta = indexMasa;
            return _listaMese[_indexMasaCurenta];
        }

        public List<Comanda> GetComenziMasaCurenta()
        {
            return _listaMese[_indexMasaCurenta].Comenzi;
        }
    }
}
