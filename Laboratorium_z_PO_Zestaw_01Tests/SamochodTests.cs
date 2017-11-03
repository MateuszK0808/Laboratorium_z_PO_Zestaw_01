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
    public class SamochodTests
    {
        [TestMethod()]
        public void SamochodTest()
        {
            Samochod s1 = new Samochod();
            Assert.AreEqual("nieznana", s1.Marka);
            Assert.AreEqual("nieznany", s1.Model);
            Assert.AreEqual(0, s1.IloscDrzwi);
            Assert.AreEqual(0, s1.PojemnoscSilnika);
            Assert.AreEqual(0.0, s1.SrednieSpalanie);
        }

        [TestMethod()]
        public void SamochodTest1()
        {

            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "ABC 123");

            Assert.AreEqual("Syrena", s2.Marka);
            Assert.AreEqual("105", s2.Model);
            Assert.AreEqual(2, s2.IloscDrzwi);
            Assert.AreEqual(800, s2.PojemnoscSilnika);
            Assert.AreEqual(7.6, s2.SrednieSpalanie);
        }

        [TestMethod()]
        public void ObliczKosztPrzejazduTest()
        {
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "CDE 456");
            Assert.AreEqual(s2.ObliczKosztPrzejazdu(30.5, 4.85), 11.2423, 0.0001);
        }
    }
}