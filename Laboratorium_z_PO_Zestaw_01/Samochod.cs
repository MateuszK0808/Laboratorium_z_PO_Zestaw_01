using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_01
{
    public class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int liczbaSamochodow = 0;
        private string numberRejstracyjny;

        public Samochod()
        {
            liczbaSamochodow++;
            Marka = "nieznana";
            Model = "nieznany";
            IloscDrzwi = 0;
            PojemnoscSilnika = 0;
            SrednieSpalanie = 0.0;
            NumberRejstracyjny = "nieznana";
        }

        public Samochod(
            string marka_,
            string model_,
            int iloscDrzwi_,
            int pojemnoscSilnika_,
            double srednieSpalanie_,
            string numberRejstracyjny_
            )
        {
            liczbaSamochodow++;
            Marka = marka_;
            Model = model_;
            IloscDrzwi = iloscDrzwi_;
            PojemnoscSilnika = pojemnoscSilnika_;
            SrednieSpalanie = srednieSpalanie_;
            NumberRejstracyjny = numberRejstracyjny_;
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value;  }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }
        public string NumberRejstracyjny
        {
            get { return numberRejstracyjny; }
            set { numberRejstracyjny = value; }
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100.0;
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
            double kosztPrzejazdu = spalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: {0}", Marka);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("IlośćDrzwi: {0}", IloscDrzwi);
            Console.WriteLine("Pojemność silnika: {0}", PojemnoscSilnika);
            Console.WriteLine("Średnie spalanie: {0}", SrednieSpalanie);
            Console.WriteLine("nrRejstracyjny: {0}", NumberRejstracyjny);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilość samochodów: {0}", liczbaSamochodow);
        }
    }
}
