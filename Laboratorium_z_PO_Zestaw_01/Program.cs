using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while(run)
            {
                Console.WriteLine("Wybierz zadanie do przetestowania");
                Console.WriteLine("Zadanie 1 wybierz 1");
                Console.WriteLine("Zadanie 2 wybierz 2");
                Console.WriteLine("Zadanie domowe wybierz 3");
                Console.WriteLine("Wyjście wybierz 0");
                string zadanie = Console.ReadLine();
                Console.Clear();
                if (zadanie == "1")
                {
                    TestZadanie1();
                }
                else if (zadanie == "2")
                {
                    TestZadanie2();
                }
                else if (zadanie == "3")
                {
                    TestZadanieDomowe();
                }
                else if (zadanie == "0")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("nieprawidłowa wartość");
                    Console.ReadKey();
                }
                Console.Clear();
            }

        }

        public static void TestZadanie1()
        {
            Samochod s1 = new Samochod();
            s1.WypiszInfo();
            s1.Marka = "Fiat";
            s1.Model = "126p";
            s1.IloscDrzwi = 2;
            s1.PojemnoscSilnika = 650;
            s1.SrednieSpalanie = 6.0;
            s1.WypiszInfo();
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "ABC 123");
            s2.WypiszInfo();
            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
            Samochod.WypiszIloscSamochodow();
            Console.ReadKey();
        }

        public static void TestZadanie2()
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "ABC 123");
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "CDE 456");
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();
            g2.WyprowadzSamochod();
            g2.WypiszInfo();
            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            Console.ReadKey();
        }

        public static void TestZadanieDomowe()
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "ABC 123");
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "CDE 456");
            Osoba osoba1 = new Osoba();
            osoba1.WypiszInfo();
            osoba1.Imie = "Adam";
            osoba1.Nazwisko = "Nowak";
            osoba1.AdresZamieszkania = "Jakis adres";
            osoba1.WypiszInfo();
            Osoba osoba2 = new Osoba("Jan", "Kowalski", "ul. Lipowa 1");
            osoba2.WypiszInfo();
            osoba2.DodajSamochod(s1.NumberRejstracyjny);
            osoba2.DodajSamochod(s2.NumberRejstracyjny);
            osoba2.WypiszInfo();
            osoba2.DodajSamochod("AVD 627");
            osoba2.DodajSamochod("GGH 009");
            osoba2.UsunSamochod(s1.NumberRejstracyjny);
            osoba2.WypiszInfo();
            Console.ReadKey();
        }
    }
}
