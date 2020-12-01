using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Commands
    {
        public static String createDatabase =
            "CREATE DATABASE IF NOT EXISTS `HHBK_Chemicals` DEFAULT CHARACTER SET utf8 ;" +
            "USE `HHBK_Chemicals` ;" +
            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Kunde` (" +
            "`Kundennummer` INT NOT NULL AUTO_INCREMENT," +
            "`Name` VARCHAR(45) NULL," +
            "`Vorname` VARCHAR(45) NULL," +
            "`Strasse` VARCHAR(45) NULL," +
            "`Hausnummer` INT NULL," +
            "`Postleitzahl` INT NULL," +
            "`Ort` VARCHAR(45) NULL," +
            "`emaliadresse` VARCHAR(45) NULL," +
            "`password` VARCHAR(45) NULL," +
            "PRIMARY KEY(`Kundennummer`));" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Produkt` (" +
            "`Artikelnummer` INT NOT NULL AUTO_INCREMENT," +
            "`Artikelname` VARCHAR(45) NOT NULL," +
            "`Verkaufseinheit` INT NOT NULL," +
            "`Einheit` VARCHAR(45) NOT NULL," +
            "`PreisVK` DOUBLE NOT NULL," +
            "PRIMARY KEY(`Artikelnummer`));" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Produktionsposition` (" +
            "`Produktionspositionsnummer` INT NOT NULL," +
            "`Produkt_Artikelnummer` INT NOT NULL," +
            "`DatumProduktionsfreigabe` DATETIME NULL," +
            "`DatumProduktion` DATETIME NULL," +
            "`NameProdkutionsfreigabe` VARCHAR(45) NULL," +
            "`NameProduzent` VARCHAR(45) NULL," +
            "`Bestellposition_Bestellpositionsnummer` INT NOT NULL," +
            "`Bestellposition_Kunde_Kundennummer` INT NOT NULL," +
            "`Produkt_Artikelnummer1` INT NOT NULL," +
            "PRIMARY KEY(`Produktionspositionsnummer`)," +
            "FOREIGN KEY(`Produkt_Artikelnummer1`)" +
            " REFERENCES `HHBK_Chemicals`.`Produkt` (`Artikelnummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Bestellposition` (" +
            "`Bestellpositionsnummer` INT NOT NULL AUTO_INCREMENT," +
            "`Bestellungsnummer` INT NOT NULL ," +
            "`Menge` INT NULL," +
            "`Bestelldatum` DATE NULL," +
            "`Kundennummer` INT NOT NULL," +
            "`Produktionspositionsnummer` INT NOT NULL," +
            "`Artikelnummer` INT NOT NULL," +
            "PRIMARY KEY(`Bestellpositionsnummer`)," +
            "FOREIGN KEY(`Kundennummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Kunde` (`Kundennummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION," +
            "FOREIGN KEY(`Artikelnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Produkt` (`Artikelnummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION," +
            "FOREIGN KEY(`Produktionspositionsnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Produktionsposition` (`Produktionspositionsnummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Zahlungseingang` (" +
            "`Zahlungseingangsnummer` INT NOT NULL AUTO_INCREMENT," +
            "`VerwendungszweckKdNr` VARCHAR(45) NOT NULL," +
            "`VerwendungszweckBestNr` VARCHAR(45) NOT NULL," +
            "`Datum` VARCHAR(45) NULL," +
            "`NameKontoinhaber` VARCHAR(45) NULL," +
            "`IBAN` VARCHAR(45) NULL," +
            "`Kundennummer` INT NOT NULL," +
            "PRIMARY KEY(`Zahlungseingangsnummer`)," +
            "FOREIGN KEY(`Kundennummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Kunde` (`Kundennummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Rechnungsposition` (" +
            "`Rechnungspositionsnummer` INT NOT NULL AUTO_INCREMENT," +
            "`Rechnungsnummer` INT NOT NULL," +
            "`Bestellpositionsnummer` INT NOT NULL," +
            "`Artikelnummer` INT NOT NULL," +
            "`Kundennummer` INT NOT NULL," +
            "PRIMARY KEY(`Rechnungspositionsnummer`)," +
            "FOREIGN KEY(`Bestellpositionsnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Bestellposition` (`Bestellpositionsnummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Lagerposition` (" +
            "`Lagerpositionsnummer` INT NOT NULL AUTO_INCREMENT," +
            "`Grundstoffname` VARCHAR(45) NOT NULL," +
            "`Grundstoffmenge` INT NOT NULL," +
            "`Gundstoffeinheit` VARCHAR(45) NOT NULL," +
            "PRIMARY KEY (`Lagerpositionsnummer`));" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Rezept` (" +
            "`Rezeptnummer` INT NOT NULL AUTO_INCREMENT," +
            "`HerstellungsdauerMin` INT NULL," +
            "`Artikelnummer` INT NOT NULL," +
            "PRIMARY KEY (`Rezeptnummer`)," +
            "FOREIGN KEY (`Artikelnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Produkt` (`Artikelnummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Produktionsplan` (" +
            "`Produktionsplannummer` INT NOT NULL AUTO_INCREMENT," +
            "`StartSoll` DATETIME NOT NULL," +
            "`StartIst` DATETIME NULL," +
            "`Produktionspositionsnummer` INT NOT NULL," +
            "`Artikelnummer` INT NOT NULL," +
            "`Bestellpositionsnummer` INT NOT NULL," +
            "`Kundennummer` INT NOT NULL," +
            "`Rezeptnummer` INT NOT NULL," +
            "PRIMARY KEY (`Produktionsplannummer`)," +
            "FOREIGN KEY (`Produktionspositionsnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Produktionsposition` (`Produktionspositionsnummer`)" +
            "ON DELETE NO ACTION" +
            "ON UPDATE NO ACTION," +
            "FOREIGN KEY (`Rezeptnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Rezept` (`Rezeptnummer`)" +
            " ON DELETE NO ACTION" +
            " ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Lieferposition` (" +
            "`idLieferposition` INT NOT NULL AUTO_INCREMENT," +
            "`Liefernummer` VARCHAR(45) NOT NULL," +
            "`Versanddatum` DATETIME NOT NULL," +
            "`Lieferdatum` DATETIME NULL," +
            "`NameVersandkontrolle` VARCHAR(45) NOT NULL," +
            "`NameSpedition` VARCHAR(45) NOT NULL," +
            "`Bestellpositionsnummer` INT NOT NULL," +
            "`Artikelnummer` INT NOT NULL," +
            "`Kundennummer` INT NOT NULL," +
            "PRIMARY KEY (`idLieferposition`)," +
            "FOREIGN KEY (`Bestellpositionsnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Bestellposition` (`Bestellpositionsnummer`)" +
            " ON DELETE NO ACTION" +
            " ON UPDATE NO ACTION);" +

            "CREATE TABLE IF NOT EXISTS `HHBK_Chemicals`.`Lagerposition_has_Rezept` (" +
            "`Lagerposition_Lagerpositionsnummer` INT NOT NULL," +
            "`Rezept_Rezeptnummer` INT NOT NULL," +
            "PRIMARY KEY (`Lagerposition_Lagerpositionsnummer`, `Rezept_Rezeptnummer`)," +
            "FOREIGN KEY (`Lagerposition_Lagerpositionsnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Lagerposition` (`Lagerpositionsnummer`)," +
            "FOREIGN KEY (`Rezept_Rezeptnummer`)" +
            " REFERENCES `HHBK_Chemicals`.`Rezept` (`Rezeptnummer`)" +
            ");";
    }
}
