/**************************************************************************
 *                                                                        *
 *  File:        Produs                                                   *
 *  Copyright:   (c) 2022,Petruca Marco-Alexandru                         *
 *  E-mail:      marco-alexandru.petruca@student.tuiasi.ro                *
 *  Description: Clasa Produs                                             *
 *               Clasa utilizata pentru a crea un produs, a pastra        *
 *               informatiile despre un produs si operatiile necesare     *
 *               acestuia                                                 *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    /// <summary>
    /// Clasa folosita pentru crearea unui produs din meniu
    /// </summary>
    class Produs
    {
        private string _denumire;
        private Double _pret;
        private List<String> _ingrediente;
        public String Denumire
        {
            get { return _denumire; }
            set { _denumire = value; }
        }

        public Double Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        /// <summary>
        /// Constructorul clasei Produs - initializeaza membrilor acesteia
        /// </summary>
        /// <param name="denumire">Denumirea produsului</param>
        /// <param name="pret">Pretul produsului (in lei)</param>
        /// <param name="ingredinte">Lista de ingrediente aferenta produsului</param>
        public Produs(String denumire, Double pret, List<String> ingredinte)
        {
            _denumire = denumire;
            _pret = pret;
            _ingrediente = new List<string>();

            if (ingredinte != null)
            {
                foreach (String ingredient in ingredinte)
                {
                    _ingrediente.Add(ingredient);
                }
            }
        }

        /// <summary>
        /// Metoda utilizata pentru a afisa lista de ingrediente a unui produs
        /// </summary>
        /// <returns>Ingredientele unui produs</returns>
        private string AfisareIngrediente()
        {
            string rezultat = "";

            for (int i = 0; i < _ingrediente.Count; i++)
            {
                rezultat += _ingrediente[i] + ", ";
            }

            return rezultat.Substring(0, rezultat.Length - 2);//trebuie sa eliminam de ultimul ", "
        }

        /// <summary>
        /// Metoda utilizata pentru a afisa toate detaliile unui produs
        /// </summary>
        /// <returns>Detaliile unui produs</returns>
        public string AfisareProdus()
        {
            return Denumire + "(" + AfisareIngrediente() + ")" + " -  " + Pret.ToString() + " lei";
        }

    }
}
