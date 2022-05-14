using System;
using System.Collections.Generic;
using System.IO;

/*
 * 
 * Ce se afla in fisierul asta sunt doar niste teste si initializari.
 * Se poate muta totul in formular, sau la initializare program, sau oriunde este potrivit :)
 * 
 */

namespace ProiectIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //citim din fisier produsele
            StreamReader sr = new StreamReader("produse.txt");
            string continutProduse = sr.ReadToEnd();
            sr.Close();

            //construim meniul SINGLETON

            string[] produse = continutProduse.Split('\n');
            List<Produs> produseMeniu = new List<Produs>();

            foreach(string prod in produse)
            {
                string[] elementeProdus = prod.Split('/');
                string denumire = elementeProdus[0];
                double pret = Double.Parse(elementeProdus[1]);
                string[] ingrediente = elementeProdus[2].Split('+');
                List<string> listaIngrediente = new List<string>();
                foreach(string ingredient in ingrediente)
                {
                    listaIngrediente.Add(ingredient);
                }
                produseMeniu.Add(new Produs(denumire, pret, listaIngrediente));
            }

            Meniu meniu = Meniu.InstantaMeniu(produseMeniu);
            Console.WriteLine(meniu.AfisareMeniu());

        }
    }
}
