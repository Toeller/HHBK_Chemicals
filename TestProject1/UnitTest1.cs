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
        public void KundenlisteXML_alter_neuerKunde()
        {
            //Arrange
            bool equals = false;

            IKundenliste kl = new KundenlisteXML();

            Kunde testkunde = new Kunde();
            testkunde.Name = "von Hinten";
            testkunde.Vorname = "Reinhardt";
            testkunde.Strasse = "Reperbahn";
            testkunde.Hausnummer = "1a";
            testkunde.Ort = "DuEselDorf";
            testkunde.Postleitzahl = 40225;
            testkunde.Emailadresse= "hotboy@ice.com";

            kl.save(testkunde);

            //Um die Kundennummer zu erhalten
            testkunde=kl.getKunde(testkunde);

            testkunde.Hausnummer = "11";

            //Act
            kl.alter(testkunde);

            //Assert
            Kunde suchKunde = new Kunde();
            suchKunde.Name = testkunde.Name;
            Kunde erg1 = kl.getKunde(suchKunde);

            //Console.WriteLine(suchKunde);
            //Console.ReadKey();

            if (erg1.Name == testkunde.Name &&
                erg1.Vorname == testkunde.Vorname &&
                erg1.Strasse == testkunde.Strasse &&
                erg1.Hausnummer == testkunde.Hausnummer &&
                erg1.Ort == testkunde.Ort &&
                erg1.Postleitzahl == testkunde.Postleitzahl)
                equals = true;
            equals = false;

            
           


            //Assert

            Assert.IsTrue(equals);

        }
    }
}
