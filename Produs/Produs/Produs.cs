using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Produs
    {
        private String _denumire;
        private Double _pret;
        private List<String> _ingrediente;

        Produs(String denumire, Double pret, List<String> ingredinte)
        {
            _denumire = denumire;
            _pret = pret;
            _ingrediente = new List<string>();

            foreach(String ingredient in ingredinte)
            {
                _ingrediente.Add(ingredient);
            }
        }

        //get si set de facut

    }
}
