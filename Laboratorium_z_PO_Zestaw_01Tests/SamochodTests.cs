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
            var samochod = new Samochod();
            Assert.AreEqual("nieznana", samochod.Marka);
            Assert.AreEqual("nieznany", samochod.Model);
            Assert.AreEqual(0, samochod.IloscDrzwi);
            Assert.AreEqual(0, samochod.PojemnoscSilnika);
            Assert.AreEqual(0.0, samochod.SrednieSpalanie);
        }

        [TestMethod()]
        public void SamochodTest1()
        {

            var s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

            Assert.AreEqual("Syrena", s2.Marka);
            Assert.AreEqual("105", s2.Model);
            Assert.AreEqual(2, s2.IloscDrzwi);
            Assert.AreEqual(800, s2.PojemnoscSilnika);
            Assert.AreEqual(7.6, s2.SrednieSpalanie);
        }
    }
}