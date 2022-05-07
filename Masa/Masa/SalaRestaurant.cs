using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class SalaRestaurant
    {
        private List<Masa> _mese;
        private int _indexMasaCurenta;
        SalaRestaurant()
        {
            _mese = new List<Masa>();
        }

        public void SetCurrentTable(int indexMasa)
        {
            _indexMasaCurenta = indexMasa;
        }

        public List<Comanda> GetComenziMasaCurenta()
        {
            return _mese[_indexMasaCurenta].GetComenzi();
        }

    }
}
