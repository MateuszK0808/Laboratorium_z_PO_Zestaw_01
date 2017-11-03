using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorium_z_PO_Zestaw_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_01.Tests
{
    [TestClass()]
    public class GarazTests
    {
        [TestMethod()]
        public void GarazTest()
        {
            Garaz g1 = new Garaz();

            Assert.AreEqual("nieznany", g1.Adres);
            Assert.AreEqual(0, g1.Pojemnosc);
        }

        [TestMethod()]
        public void GarazTest1()
        {
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);

            Assert.AreEqual("ul. Garażowa 2", g2.Adres);
            Assert.AreEqual(2, g2.Pojemnosc);
        }

        [TestMethod()]
        public void WyprowadzSamochodTest()
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

            Garaz g2 = new Garaz("ul. Garażowa 2", 2);

            Assert.IsNull(g2.WyprowadzSamochod());
            g2.WprowadzSamochod(s1);
            Assert.AreEqual(g2.WyprowadzSamochod(), s1);
            g2.WprowadzSamochod(s1);
            g2.WprowadzSamochod(s2);
            Assert.AreEqual(g2.WyprowadzSamochod(), s2);
        }
    }
}