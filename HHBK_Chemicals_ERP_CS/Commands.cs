using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    class Commands
    {
        private static String createDatabase =
            "CREATE DATABASE IF NOT EXISTS `HHBK_Chemicals` DEFAULT CHARACTER SET utf8; " +
            "USE `HHBK_Chemicals`; " +

            "CREATE TABLE IF NOT EXISTS `Kunde` ( " +
            "`Kundennummer` INT NOT NULL AUTO_INCREMENT, " +
            "`Name` VARCHAR(45) NULL, " +
            "`Vorname` VARCHAR(45) NULL, " +
            "`Strasse` VARCHAR(45) NULL, " +
            "`Hausnummer` INT NULL, " +
            "`Postleitzahl` INT NULL, " +
            "`Ort` VARCHAR(45) NULL, " +
            "`emaliadresse` VARCHAR(45) NULL, " +
            "`passwort` VARCHAR(45) NULL, " +
            "PRIMARY KEY(`Kundennummer`)) " +
            "ENGINE = InnoDB; " +

            "CREATE TABLE IF NOT EXISTS `Produkt` ( " +
            "`Artikelnummer` INT NOT NULL AUTO_INCREMENT, " +
            "`Artikelname` VARCHAR(45) NOT NULL, " +
            "`Verkaufseinheit` INT NOT NULL, " +
            "`Einheit` VARCHAR(45) NOT NULL, " +
            "`PreisVK` DOUBLE NOT NULL, " +
            "`ChemischeBezeichnung` VARCHAR(45) NULL, " +
            "PRIMARY KEY(`Artikelnummer`)) " +
            "ENGINE = InnoDB; " +

            "CREATE TABLE IF NOT EXISTS Bestellposition( " +
            "`Bestellpositionsnummer` INT NOT NULL AUTO_INCREMENT, " +
            "`Bestellungsnummer` INT NOT NULL , " +
            "`Menge` INT NULL, " +
            "`Bestelldatum` DATE NULL, " +
            "`Artikelnummer` INT NOT NULL, " +
            "`Kundennummer` INT NOT NULL, " +
            "`Lieferpositionsnummer` INT, " +
            "PRIMARY KEY (`Bestellpositionsnummer`)); " +

            "CREATE TABLE IF NOT EXISTS Produktionsposition( " +
            "`Produktionspositionsnummer` INT NOT NULL, " +
            "`Artikelnummer` INT NOT NULL, " +
            "`DatumProduktionsfreigabe` DATETIME NULL, " +
            "`DatumProduktion` DATETIME NULL, " +
            "`NameProdkutionsfreigabe` VARCHAR(45) NULL, " +
            "`NameProduzent` VARCHAR(45) NULL, " +
            "`Bestellpositionsnummer` INT NOT NULL, " +
            "`Kundennummer` INT NOT NULL, " +
            "PRIMARY KEY(`Produktionspositionsnummer`)); " +

            "CREATE TABLE IF NOT EXISTS `Zahlungseingang` ( " +
            "`Zahlungseingangsnummer` INT NOT NULL AUTO_INCREMENT, " +
            "`VerwendungszweckKdNr` VARCHAR(45) NOT NULL, " +
            "`VerwendungszweckBestNr` VARCHAR(45) NOT NULL, " +
            "`Datum` VARCHAR(45) NULL, " +
            "`NameKontoinhaber` VARCHAR(45) NULL, " +
            "`IBAN` VARCHAR(45) NULL, " +
            "`Kundennummer` INT NOT NULL, " +
            "PRIMARY KEY(`Zahlungseingangsnummer`), " +
            "FOREIGN KEY(`Kundennummer`) " +
            "REFERENCES `HHBK_Chemicals`.`Kunde` (`Kundennummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION); " +

            "CREATE TABLE IF NOT EXISTS `Rechnungsposition` ( " +
            "`Rechnungspositionsnummer` INT NOT NULL AUTO_INCREMENT, " +
            "`Rechnungsnummer` INT NOT NULL, " +
            "`Bestellpositionsnummer` INT NOT NULL, " +
            "`Artikelnummer` INT NOT NULL, " +
            "`Kundennummer` INT NOT NULL, " +
            "PRIMARY KEY(`Rechnungspositionsnummer`), " +
            "FOREIGN KEY(`Bestellpositionsnummer`) " +
            "REFERENCES `HHBK_Chemicals`.`Bestellposition` (`Bestellpositionsnummer`) " +
            "ON DELETE NO ACTION " +
            "ON UPDATE NO ACTION) " +
            "ENGINE = InnoDB; " +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Lagerposition` ( " +
            "`Lagerpositionsnummer` INT NOT NULL AUTO_INCREMENT, " +
            "`Grundstoffname` VARCHAR(45) NOT NULL, " +
            "`Grundstoffmenge` INT NOT NULL, " +
            "`Gundstoffeinheit` VARCHAR(45) NOT NULL, " +
            "PRIMARY KEY(`Lagerpositionsnummer`)) " +
            "ENGINE = InnoDB; " +

            "CREATE TABLE IF NOT EXISTS `Rezept` ( " +
            "`Rezeptnummer` INT NOT NULL AUTO_INCREMENT, " +
            "`HerstellungsdauerMin` INT NULL, " +
            "`Artikelnummer` INT NOT NULL, " +
            "PRIMARY KEY(`Rezeptnummer`), " +
            "FOREIGN KEY(`Artikelnummer`) " +
            "REFERENCES `HHBK_Chemicals`.`Produkt` (`Artikelnummer`) " +
            "ON DELETE NO ACTION " +
            "ON UPDATE NO ACTION) " +
            "ENGINE = InnoDB; " +

            "CREATE TABLE IF NOT EXISTS `Produktionsplan` ( " +
            "`Produktionsplannummer` INT NOT NULL AUTO_INCREMENT, " +
            "`StartSoll` DATETIME NOT NULL, " +
            "`StartIst` DATETIME NULL, " +
            "`Produktionspositionsnummer` INT NOT NULL, " +
            "`Artikelnummer` INT NOT NULL, " +
            "`Bestellpositionsnummer` INT NOT NULL, " +
            "`Kundennummer` INT NOT NULL, " +
            "`Rezeptnummer` INT NOT NULL, " +
            "PRIMARY KEY (`Produktionsplannummer`)); " +

            "CREATE TABLE IF NOT EXISTS `Lieferposition` ( " +
            "`idLieferposition` INT NOT NULL AUTO_INCREMENT, " +
            "`Liefernummer` VARCHAR(45) NOT NULL, " +
            "`Versanddatum` DATETIME NOT NULL, " +
            "`Lieferdatum` DATETIME NULL, " +
            "`NameVersandkontrolle` VARCHAR(45) NOT NULL, " +
            "`NameSpedition` VARCHAR(45) NOT NULL, " +
            "`Bestellpositionsnummer` INT NOT NULL, " +
            "`Artikelnummer` INT NOT NULL, " +
            "`Kundennummer` INT NOT NULL, " +
            "PRIMARY KEY (`idLieferposition`), " +
            "FOREIGN KEY (`Bestellpositionsnummer`) " +
            "REFERENCES `Bestellposition` (`Bestellpositionsnummer`) " +
            "ON DELETE NO ACTION " +
            "ON UPDATE NO ACTION) " +
            "ENGINE = InnoDB; " +

            "CREATE TABLE IF NOT EXISTS `Lagerposition_has_Rezept` ( " +
            "`Lagerposition_Lagerpositionsnummer` INT NOT NULL, " +
            "`Rezept_Rezeptnummer` INT NOT NULL, " +
            "PRIMARY KEY (`Lagerposition_Lagerpositionsnummer`, `Rezept_Rezeptnummer`)); " +

            "ALTER TABLE `Lagerposition_has_Rezept` " +
            "ADD FOREIGN KEY (`Lagerposition_Lagerpositionsnummer`) " +
            "REFERENCES `HHBK_Chemicals`.`Lagerposition` (`Lagerpositionsnummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE `Lagerposition_has_Rezept` " +
            "ADD FOREIGN KEY (`Rezept_Rezeptnummer`) " +
            "REFERENCES `HHBK_Chemicals`.`Rezept` (`Rezeptnummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Produktionsposition " +
            "ADD FOREIGN KEY (Bestellpositionsnummer) " +
            "REFERENCES Bestellposition(Bestellpositionsnummer) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Produktionsposition " +
            "ADD FOREIGN KEY (Artikelnummer) " +
            "REFERENCES Produkt(Artikelnummer) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE  Produktionsposition " +
            "ADD FOREIGN KEY (Kundennummer) " +
            "REFERENCES Kunde(Kundennummer) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Bestellposition " +
            "ADD FOREIGN KEY (`Kundennummer`) " +
            "REFERENCES `Kunde` (`Kundennummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Bestellposition " +
            "ADD FOREIGN KEY (`Artikelnummer`) " +
            "REFERENCES `Produkt` (`Artikelnummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Bestellposition " +
            "ADD FOREIGN KEY (`Lieferpositionsnummer`) " +
            "REFERENCES `Lieferposition` (`idLieferposition`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Produktionsplan " +
            "ADD FOREIGN KEY (`Produktionspositionsnummer`) " +
            "REFERENCES `Produktionsposition` (`Produktionspositionsnummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION; " +

            "ALTER TABLE Produktionsplan " +
            "ADD FOREIGN KEY (`Rezeptnummer`) " +
            "REFERENCES `Rezept` (`Rezeptnummer`) " +
            "ON DELETE NO ACTION ON UPDATE NO ACTION;";
        public static String CreateDatabase { get => createDatabase; }

        private static String createTestdata =
            "INSERT INTO Kunde " +
            "VALUES " +
            "(10001, \"Hans\", \"Martin\", \"Schleyerstr.\",77,77654,\"Offenburg\",\"hms@gmx.de\",password(\"12345\")), " +
            "(22000, \"Morricone\", \"Ennio\", \"Dan-Savio-Str.\", 20, 50667, \"Köln\", \"MorriconeE@live.it\", password(\"34567\")), " +
            "(30303, \"Liebig\", \"Justus\", \"Münchener Str.\", 73, 64283, \"Darmstadt\", \"Justu73@gmail.com\", password(\"justus\")), " +
            "(40440, \"King-Noel\", \"Augusta\", \"London Weg\", 52, 50674, \"Köln\", \"Ada52@space.co.uk\", password(\"king23\")), " +
            "(15000, \"Kramer\", \"Ingo\", \"Bremerhavener Str.\", 35, 28195, \"Bremen\", \"Ingo.Kraer@bda.de\", password(\"hilde\")), " +
            "(10002, \"Müller\", \"Mohamed\", \"Düsseldorfer Str.\", 27, 77654, \"Offenburg\", \"muemo@gmx.de\", password(\"12345\")), " +
            "(22002, \"Meyer\", \"Irene\", \"Don-Camillo-Platz\", 22, 77654, \"Offenburg\", \"IreneOf@live.co.uk\", password(\"7.1.1997\")), " +
            "(30304, \"Bostanci\", \"Karl\", \"Mühlenstr.\", 88, 64283, \"Darmstadt\", \"kabo@web.de\", password(\"dhklaju2\")), " +
            "(40442, \"Gustahvson\", \"Horst\", \"Landweg\", 173, 50735, \"Köln\", \"Horst@GuSo.com\", password(\"&h8D23\")), " +
            "(15001, \"Ötztürk\", \"Sabine\", \"Hafenstr.\", 31, 28211, \"Bremen\", \"Ötzi@zillertal.at\", password(\"T%5hL12\")); " +

            "INSERT INTO Produkt " +
            "VALUES " +
            "(1, \"Orangenaroma\", 1, \"l\", 12.89), " +
            "(2, \"Zitronenaroma\", 1, \"l\", 11.99), " +
            "(3, \"Birnenaroma\", 2, \"l\", 25.00), " +
            "(4, \"Zimtaroma\", 2, \"l\", 12.89), " +
            "(5, \"Rumaroma\", 1, \"l\", 17.90); " +

            "INSERT INTO bestellposition " +
            "VALUES " +
            "(1,1,2,\"2020-11-30\",5,22000,NULL), " +
            "(2,1,1,\"2020-11-30\",3,22000,NULL), " +
            "(3,2,3,\"2020-12-03\",1,15001,NULL), " +
            "(4,2,6,\"2020-12-03\",2,15000,NULL), " +
            "(5,3,1,\"2020-12-30\",3,30304,NULL), " +
            "(6,3,2,\"2020-12-30\",4,30304,NULL), " +
            "(7,3,2,\"2020-12-30\",3,30304,NULL), " +
            "(8,3,1,\"2020-12-30\",2,30304,NULL), " +
            "(9,3,3,\"2020-12-30\",5,30304,NULL), " +
            "(12,4,3,\"2020-12-06\",1,15001,NULL); " +

            "INSERT INTO rechnungsposition " +
            "VALUES " +
            "(1,1,1,5,22000), " +
            "(2,1,2,3,22000), " +
            "(3,2,3,1,15001), " +
            "(4,3,4,2,15000), " +
            "(5,4,5,3,30304), " +
            "(6,4,6,4,30304), " +
            "(7,4,7,3,30304), " +
            "(8,4,8,2,30304), " +
            "(9,4,9,5,30304), " +
            "(10,5,12,1,15001); " +

            "INSERT INTO produktionsposition " +
            "VALUES " +
            "(1,5,\"2020-12-01\",\"2020-12-20\",\"Jonston\",\"Pansa\",1,22000), " +
            "(2,4,\"2020-12-01\",\"2020-12-21\",\"Harris\",\"Huber\",6,30304), " +
            "(3,5,\"2020-12-02\",\"2020-12-23\",\"Jonston\",\"Huber\",9,30304), " +
            "(4,3,\"2020-12-04\",\"2020-12-22\",\"Jagalamudi\",\"El Arsenal\",2,22000), " +
            "(5,3,\"2020-12-04\",\"2021-01-08\",\"Jagalamudi\",\"El Arsenal\",5,30304), " +
            "(6,3,\"2020-12-04\",\"2021-01-08\",\"Jagalamudi\",\"Pansa\",7,30304), " +
            "(7,1,\"2020-12-07\",\"2020-12-20\",\"Jonston\",\"Huber\",3,15001), " +
            "(8,2,\"2020-12-07\",\"2020-12-21\",\"Harris\",\"El Arsenal\",4,15000), " +
            "(9,2,\"2020-12-08\",\"2020-12-23\",\"Jonston\",\"El Arsenal\",8,30304), " +
            "(10,1,\"2020-12-08\",\"2020-12-22\",\"Lustig\",\"Quichotte\",12,15001); "

            ;

        public static String CreateTestdata { get => createTestdata; }
        public static string GetProduktIDandName { get => getProduktIDandName; set => getProduktIDandName = value; }

        private static String getProduktIDandName = "SELECT * FROM produkt";

        public static string change(Produkt p)
        {
            MessageBox.Show("Uuups... \n Query zum Produktändern fehlt!");

            return "                     ";
        }

        public static string delete(Produkt p)
        {
            MessageBox.Show("Uuups... \n Query zum Produktlöschen fehlt!");

            return "                    ";
        }


    }
}
