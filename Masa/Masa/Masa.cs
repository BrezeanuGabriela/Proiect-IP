using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Masa : IMasa
    {
        
        private int _index;

        public Masa()
        {
            _index = _nrMese;
            _comenzi = new List<Comanda>();
        }

        ///<summary>
        ///Metoda care adauga comanda curenta la lista de comenzi de pe masa
        ///</summary>
        ///<param name="comanda">Comanda care a fost data la masa</param>
        public override void AddComanda(Comanda comanda)
        {
            _comenzi.Add(comanda);
        }

        public override Comanda GetComanda(int index)
        {
            return _comenzi[index];
        }

        public override void StergeComanda(Comanda comanda)
        {
            _comenzi.Remove(comanda);
        }

        public override double TotalCostComenziMasa()
        {
            double cost = 0.0;
            foreach(Comanda comanda in _comenzi)
            {
                cost += comanda.Facturare();
            }
            return cost;
        }

    }
}
