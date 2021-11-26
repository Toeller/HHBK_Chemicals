using HHBK_Chemicals_ERP_CS;
using HHBK_Chemicals_ERP_CS.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool equals = false;
            IKundenliste kl = new KundenlisteXML();

            Kunde testkunde =
                new Kunde(69, "von Hinten", "Reinhardt", "Reperbahn", "1a", "DuEselDorf", 40225, "hotboy@ice.com");

            kl.save(testkunde);

            Kunde erg1 = kl.getKunde(testkunde);

            if (erg1.Name == testkunde.Name &&
                erg1.Vorname == testkunde.Vorname &&
                erg1.Strasse == testkunde.Strasse &&
                erg1.Hausnummer == testkunde.Hausnummer &&
                erg1.Ort == testkunde.Ort &&
                erg1.Postleitzahl == testkunde.Postleitzahl)
                equals = true;
            equals = false;




            //Act


            //Assert

            Assert.IsTrue(equals);

        }
    }
}
