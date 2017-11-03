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
    public class OsobaTests
    {
        [TestMethod()]
        public void OsobaTest()
        {
            Osoba osoba = new Osoba();
            Assert.AreEqual("nieznane", osoba.Imie);
            Assert.AreEqual("nieznane", osoba.Nazwisko);
            Assert.AreEqual("nieznany", osoba.AdresZamieszkania);
        }

        [TestMethod()]
        public void OsobaTest1()
        {
            Osoba osoba = new Osoba("Jan", "Kowalski", "adres");
            Assert.AreEqual("Jan", osoba.Imie);
            Assert.AreEqual("Kowalski", osoba.Nazwisko);
            Assert.AreEqual("adres", osoba.AdresZamieszkania);
        }
    }
}