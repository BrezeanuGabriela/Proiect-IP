using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Produs
    {
        private string _denumire;
        public String Denumire
        {
            get { return _denumire; }
            set { _denumire = value; }
        }

        private Double _pret;
        public Double Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }
        private List<String> _ingrediente;

        public Produs(String denumire, Double pret, List<String> ingredinte)
        {
            _denumire = denumire;
            _pret = pret;
            _ingrediente = new List<string>();

            foreach (String ingredient in ingredinte)
            {
                _ingrediente.Add(ingredient);
            }
        }

        private string AfisareIngrediente()
        {
            string rezultat = "";

            for (int i = 0; i < _ingrediente.Count; i++)
            {
                rezultat += _ingrediente[i] + ", ";
            }

            return rezultat.Substring(0, rezultat.Length - 2);//trebuie sa eliminam de ultimul ", "
        }

        public string AfisareProdus()
        {
            return Denumire + "(" + AfisareIngrediente() + ")" + " -  " + Pret.ToString() + " lei" ;
        }

        public void AdaugaIngredient(string ingredient)
        {
            //verificare daca ingredientul exista deja in lista de ingrediente
            bool ok = true;
            foreach (string ingr in _ingrediente)
            {
                if (ingr == ingredient)
                {
                    ok = false;
                }
            }
            if (ok)
            {
                Console.WriteLine("Am adaugat ingredientul: " + ingredient + " in produsul: " + Denumire);
                _ingrediente.Add(ingredient);
            }
        }

        public void EliminareIngredient(string ingredient)
        {
            //verificare daca ingredientul este in produs
            try
            {
                _ingrediente.Remove(ingredient);
                Console.WriteLine("Am eliminat ingredientul: " + ingredient + " din produsul: " + Denumire);
            }
            catch
            {
                Console.WriteLine("Ingredientul: " + ingredient + " nu se afla in produsul: " + Denumire + "\n");
            }

        }
    }
}
