/**************************************************************************
 *                                                                        *
 *  File:        UnitTestProdusMeniu                                      *
 *  Copyright:   (c) 2022,Petruca Marco-Alexandru                         *
 *  E-mail:      marco-alexandru.petruca@student.tuiasi.ro                *
 *  Description: Clasa UnitTestProdusMeniu                                *
 *               Clasa utilizata pentru testarea unitatilor Meniu si      *
 *               Produs                                                   *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProiectIP;
using System.Collections.Generic;

namespace UnitTestProduseMeniu
{
    [TestClass]
    public class UnitTest1
    {
        // Teste pentru metoda "AfisareProdus" din Produs.cs
        [TestMethod]
        public void TestAfisareProdusNormal()
        {
            List<string> ingrediente = new List<string>{ "ciorba","ulei" };
            Produs p = new Produs("ciorba", 25,ingrediente);
            Assert.AreEqual("ciorba(ciorba, ulei)  -  25 lei", p.AfisareProdus());
            //Denumire + "(" + AfisareIngrediente() + ")" + " -  " + Pret.ToString() + " lei"
        }

        [TestMethod]
        public void TestAfisareProdusIngredienteGol()
        {
            List<string> ingrediente = new List<string> {  };
            Produs p = new Produs("ciorba", 25, ingrediente);
            Assert.AreEqual("ciorba() -  25", p.AfisareProdus());
        }

        [TestMethod]
        public void TestAfisareProdusNumeGol()
        {
            List<string> ingrediente = new List<string> { "ciorba", "ulei" };
            Produs p = new Produs("", 25, ingrediente);
            Assert.AreEqual("(ciorba,ulei) -  25 lei", p.AfisareProdus());
        }

        // Teste pentru "AfisareMeniu" din Meniu.cs

        [TestMethod]
        public void TestAfisareMeniulNormal()
        {
            
            List<string> ingrediente1 = new List<string> { "ciorba", "ulei","carne pui" };
            Produs p1 = new Produs("ciorba carne pui", 25, ingrediente1);
            List<string> ingrediente2 = new List<string> { "ciorba", "ulei", "carne vaca" };
            Produs p2 = new Produs("ciorba carne vaca", 30, ingrediente2);
            List<string> ingrediente3 = new List<string> { "ciorba", "ulei", "carne berbec" };
            Produs p3 = new Produs("ciorba carne berbec", 35, ingrediente3);

            List<Produs> listaProduse = new List<Produs> { p1, p2, p3 };
            Meniu meniu = Meniu.InstantaMeniu(listaProduse);

            Assert.AreEqual("ciorba carne pui(ciorba, ulei, carne pui) -  25 lei\nciorba carne vaca(ciorba, ulei, carne vaca) -  30 lei\nciorba carne berbec(ciorba, ulei, carne berbec) -  35 lei\n", meniu.AfisareMeniu());
        
        }

        

        [TestMethod]
        public void TestAfisareMeniulProduseFaraIngredienteSauFaraNume()
        {
            List<string> ingrediente1 = new List<string> { "ciorba", "ulei", "carne pui" };
            Produs p1 = new Produs("ciorba carne pui", 25, ingrediente1);
            List<string> ingrediente2 = new List<string> {  };
            Produs p2 = new Produs("ciorba carne vaca", 30, ingrediente2);
            List<string> ingrediente3 = new List<string> { "ciorba", "ulei", "carne berbec" };
            Produs p3 = new Produs("", 35, ingrediente3);

            List<Produs> listaProduse = new List<Produs> { p1, p2, p3 };

            Meniu meniu = Meniu.InstantaMeniu(listaProduse);

            Assert.AreEqual("ciorba carne pui(ciorba, ulei, carne pui) -  25 lei\nciorba carne vaca() -  30 lei\n(ciorba, ulei, carne berbec) -  35 lei\n", meniu.AfisareMeniu());
        }

        [TestMethod]
        public void TestAfisareMeniulProduseFaraInformatii()
        {
            List<string> ingrediente1 = new List<string> {  };
            Produs p1 = new Produs("", 1, ingrediente1);
            List<string> ingrediente2 = new List<string> {  };
            Produs p2 = new Produs("", 1, ingrediente2);
            List<string> ingrediente3 = new List<string> {  };
            Produs p3 = new Produs("", 1, ingrediente3);

            List<Produs> listaProduse = new List<Produs> { p1, p2, p3 };

            Meniu meniu = Meniu.InstantaMeniu(listaProduse);

            Assert.AreEqual("() -  1 lei\n() -  1 lei\n() -  1 lei\n", meniu.AfisareMeniu());
        }
    }
}
