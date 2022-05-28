using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meniu
    {

        private static Meniu _instantaMeniu;

        List<Produs> _produse;

        private Meniu(List<Produs> produse)
        {
            _produse = new List<Produs>();

            foreach (Produs produs in produse)
            {
                _produse.Add(produs);
            }
        }

        public static Meniu InstantaMeniu(List<Produs> produse = null)
        {
            if (_instantaMeniu == null)
            {
                //punem totul intr-un try-catch ca sa nu primim eroare cand incercam sa returnam instanta meniului.
                try
                {
                    _instantaMeniu = new Meniu(produse);
                }
                catch
                {
                    Console.WriteLine("Produse=null...");
                }
            }
            return _instantaMeniu;
        }

        public string AfisareMeniu()
        {
            string rezultat = "";

            foreach (Produs produs in _produse)
            {
                rezultat += produs.AfisareProdus() + "\n";
            }

            return rezultat;
        }

        public void AdaugareProdus(Produs produs)
        {
            //verificam daca produsul exista deja in meniu
            bool ok = true;
            foreach (Produs prod in _produse)
            {
                if (prod == produs)
                {
                    ok = false;
                }
            }
            if (ok)
            {
                Console.WriteLine("Am adaugat produsul: " + produs.Denumire + " in meniu!");
                _produse.Add(produs);
            }
        }

        public void EliminareProdus(Produs produs)
        {
            //verificam daca produsul este in meniu
            try
            {
                _produse.Remove(produs);
                Console.WriteLine("Am scors produsul: " + produs.Denumire + " din meniu!");
            }
            catch
            {
                Console.WriteLine("Produsul: " + produs.Denumire + " nu se afla in meniu!");
            }

        }

    }
}
