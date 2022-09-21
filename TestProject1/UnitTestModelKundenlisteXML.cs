using System;
using System.Collections.Generic;
using System.Text;
using HHBK_Chemicals_ERP_CS;
using HHBK_Chemicals_ERP_CS.model;


//Fuer den Test hinzugefügt:
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{

    [TestClass]
    public class UnitTestModelKundenlisteXML
    {
        private IKundenliste kl = new KundenlisteXML();
        private Kunde testkunde = new Kunde();

        [TestMethod]
        public void save_Kunde()
        {
            //Arrange
            
            testkunde.Name = "TestName";
            testkunde.Vorname = "TestVorname";
            testkunde.Strasse = "TestStrasse";
            testkunde.Hausnummer = "TestHausnummer";
            testkunde.Ort = "TestOrt";
            testkunde.Postleitzahl = 99999;
            testkunde.Emailadresse = "Test@Email.adresse";

            //Testen, ob es diesen Kunden schon im XML-File gibt.

            //Act
            kl.save(testkunde); 
            //Die Prüfung auf Vorhandensein funktioniert, für eine Auswertung dieses Ereignisses wird noch eine Rückgabe benötigt.


            //testkunde.Kundennummer=kl.getKunde(testkunde).Kundennummer;

            //Assert
            //Assert.IsTrue(kl.getKunde(testkunde).Kundennummer!=0);

            //Kunde vergleichsKunde = kl.getKunde(testkunde);//Sollten nur Inhaltsgleich sein

            Kunde testkunde1 = new Kunde();
            Kunde testkunde2 = new Kunde();
            Kunde testkunde3 = testkunde1;

            testkunde1.Kundennummer = 1;
            testkunde1.Name = "TestName";
            testkunde1.Vorname = "TestVorname";
            testkunde1.Strasse = "TestStrasse";
            testkunde1.Hausnummer = "TestHausnummer";
            testkunde1.Ort = "TestOrt";
            testkunde1.Postleitzahl = 99999;
            testkunde1.Emailadresse = "Test@Email.adresse";
            testkunde1.Passwort = "1234";

            testkunde2.Kundennummer = 1;
            testkunde2.Name = "TestName";
            testkunde2.Vorname = "TestVorname";
            testkunde2.Strasse = "TestStrasse";
            testkunde2.Hausnummer = "TestHausnummer";
            testkunde2.Ort = "TestOrt";
            testkunde2.Postleitzahl = 99999;
            testkunde2.Emailadresse = "Test@Email.adresse";
            testkunde2.Passwort = "1234";

            testkunde1.

            //Assert.IsTrue(testkunde1 == testkunde2); //gleiche Inhalte (failed)
            //Assert.IsTrue(testkunde1 == testkunde3);//gleiche Objekte (passed)

            Assert.AreEqual(testkunde1,testkunde2);//Methode ist für Werte gedacht! //gleiche Inhalte (failed)
            //Assert.AreEqual(testkunde1, testkunde3); //gleiche Objekte (passed)

            //Assert.AreSame(testkunde1,testkunde2);//Methode ist für Objekte gedacht!  //gleiche Inhalte (failed)
            Assert.AreSame(testkunde1, testkunde3); //gleiche Objekte (passed)

            testkunde1.Equals(testkunde2);
        }

        [TestMethod]
        public void getKunde_Kunde()
        {
            //Arange
            testkunde.Name = "TestName";
            testkunde.Vorname = "TestVorname";
            testkunde.Strasse = "TestStrasse";
            testkunde.Hausnummer = "TestHausnummer";
            testkunde.Ort = "TestOrt";
            testkunde.Postleitzahl = 99999;
            testkunde.Emailadresse = "Test@Email.adresse";

            //Act+Assert
            Assert.IsTrue(kl.getKunde(testkunde).Kundennummer != 0);
        }

        [TestMethod]
        public void KundenGet()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void alter_Kunde_GeaenderterKunde() {
            //Arrange
            bool equals = false;

            //Arange
            testkunde.Name = "TestName";
            testkunde.Vorname = "TestVorname";
            testkunde.Strasse = "TestStrasse";
            testkunde.Hausnummer = "TestHausnummer";
            testkunde.Ort = "TestOrt";
            testkunde.Postleitzahl = 99999;
            testkunde.Emailadresse = "Test@Email.adresse";

            testkunde = kl.getKunde(testkunde);
            
            testkunde.Name = "TestName2";
            testkunde.Vorname = "TestVorname2";
            testkunde.Strasse = "TestStrasse2";
            testkunde.Hausnummer = "TestHausnummer2";
            testkunde.Ort = "TestOrt2";
            testkunde.Postleitzahl = 99998;
            testkunde.Emailadresse = "Test2@Email2.adresse2";

            
            //Act
            kl.alter(testkunde); //Durch das Ändern sind wieder doppelte Datensätze möglich.
                                    //Das muss verhindert werden

            //Assert
            Kunde suchKunde = new Kunde();
            suchKunde.Name = testkunde.Name;
            Kunde erg1 = kl.getKunde(suchKunde);

            

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

        [TestMethod]
        public void delete_Kunde()
        {
            Assert.IsTrue(false);
        }
    }
}
