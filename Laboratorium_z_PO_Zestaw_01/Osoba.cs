using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_01
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow = 0;
        private string[] samochody = new string[3];

        public Osoba()
        {
            Imie = "nieznane";
            Nazwisko = "nieznane";
            AdresZamieszkania = "nieznany";
        }

        public Osoba(string imie_, string nazwisko_, string adresZamieszkania_)
        {
            Imie = imie_;
            Nazwisko = nazwisko_;
            AdresZamieszkania = adresZamieszkania_;
        }
        
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }

        public void DodajSamochod(string nrRejstracyjny)
        {
            if (iloscSamochodow < 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (samochody[i] == null)
                    {
                        samochody[i] = nrRejstracyjny;
                        iloscSamochodow++;
                        break;
                    }
                }
            } else
            {
                Console.WriteLine("Jedna osoba nie może posiadać więcej samochodów");
            }
        }
        public void UsunSamochod(string nrRejstracyjny)
        {
            for (int i = 0; i < 3; i++)
            {
                if (samochody[i] == nrRejstracyjny)
                {
                    samochody[i] = null;
                    iloscSamochodow--;
                    break;
                }
            }
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Imie: {0}", Imie);
            Console.WriteLine("Nazwisko: {0}", Nazwisko);
            Console.WriteLine("Adres zamieszkania: {0}", AdresZamieszkania);
            if (iloscSamochodow > 0)
            {
                Console.WriteLine("Samochody: ");
            }
            for (int i = 0; i < 3; i++)
            {
                if (samochody[i] != null)
                {
                    Console.WriteLine("  - {0}", samochody[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
