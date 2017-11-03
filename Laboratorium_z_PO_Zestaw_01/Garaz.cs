using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_01
{
    public class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public Garaz()
        {
            Adres = "nieznany";
            Pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string adres_, int pojemnosc_)
        {
            Adres = adres_;
            Pojemnosc = pojemnosc_;
        }

        public string Adres
        {
            get { return adres;  }
            set { adres = value; }
        }
        public int Pojemnosc
        {
            get { return pojemnosc; }
            set {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (samochody.Length > liczbaSamochodow)
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            } else
            {
                Console.WriteLine("Garaż jest pełny");
            }

        }

        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow > 0)
            {
                liczbaSamochodow--;
                Samochod samochod = samochody[liczbaSamochodow];
                samochody[liczbaSamochodow] = null;
                return samochod;

            } else
            {
                Console.WriteLine("Garaż jest pusty");
                return samochody[liczbaSamochodow];
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Adres: {0}", Adres);
            Console.WriteLine("Pojemnosc: {0}", Pojemnosc);
            Console.WriteLine("Liczba samochodów: {0}", liczbaSamochodow);
            Console.WriteLine("Samochody: ");

            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }
        }
    }
}
