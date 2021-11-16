using HHBK_Chemicals_ERP_CS.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HHBK_Chemicals_ERP_CS
{
    public class KundenlisteXML : IKundenliste
    {
        private List<Kunde> kunden = new List<Kunde>();
        private XDocument doc;

        public KundenlisteXML()
        {
            this.refresh();
        }

        List<Kunde> IKundenliste.Kunden { get { this.refresh(); return kunden; }}

        void IKundenliste.alter(Kunde kunde)
        {
            doc = XDocument.Load(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");

            foreach (XElement el in doc.Descendants("kunde").Where(
                         element => element.Attribute("kundennummer").Value == kunde.Kundennummer.ToString()))
            {
                el.Attribute("kundennummer").Value = kunde.Kundennummer.ToString();
                el.Element("nachname").Value = kunde.Name;
                el.Element("vorname").Value = kunde.Vorname;
                el.Element("strasse").Value = kunde.Strasse;
                el.Element("hausnummer").Value = kunde.Hausnummer;
                el.Element("ort").Value = kunde.Ort;
                el.Element("plz").Value = kunde.Postleitzahl.ToString();
                el.Element("email").Value = kunde.Emailadresse;
            }

            doc.Save(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");

            refresh();
        }

        void IKundenliste.delete(Kunde kunde)
        {
            doc = XDocument.Load(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");
            doc.Descendants("kunde").
                Where(
                        element =>
                        element.Attribute("kundennummer").Value == kunde.Kundennummer.ToString()
                      ).Remove();
            refresh();
        }

        void IKundenliste.save(Kunde kunde)
        {
            doc = XDocument.Load(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");
            doc.Descendants("kunde").
                Where(
                        element =>
                        Convert.ToInt32(element.Attribute("kundennummer").Value) < kunde.Kundennummer).
                        Last().AddAfterSelf(
                            new XElement("kunde",
                                new XAttribute("kundennummer", kunde.Kundennummer.ToString()),
                                new XElement("nachname", kunde.Name),
                                new XElement("vorname", kunde.Vorname),
                                new XElement("strasse", kunde.Strasse),
                                new XElement("hausnummer", kunde.Hausnummer),
                                new XElement("plz", kunde.Postleitzahl.ToString()),
                                new XElement("ort", kunde.Ort),
                                new XElement("email", kunde.Emailadresse)
            ));
            doc.Save(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");

            refresh();
        }

        Kunde IKundenliste.getKunde(int kundennummer)
        {
            Kunde kunde = new Kunde();
            doc = XDocument.Load(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");

            foreach (XElement el in doc.Descendants("kunde").Where(
                         element => element.Attribute("kundennummer").Value == kunde.Kundennummer.ToString()))
            {
                kunde.Kundennummer = Convert.ToInt32(el.Attribute("kundennummer").Value);
                kunde.Name = el.Element("nachname").Value;
                kunde.Vorname = el.Element("vorname").Value;
                kunde.Strasse = el.Element("strasse").Value;
                kunde.Hausnummer = el.Element("hausnummer").Value;
                kunde.Ort = el.Element("ort").Value;
                kunde.Postleitzahl = Convert.ToInt32(el.Element("plz").Value);
                kunde.Emailadresse = el.Element("email").Value;
            }

            return kunde;
        }


        void refresh()
        {
            XDocument doc = XDocument.Load(@"C:\Users\TOEL.HERTZ\source\repos\Toeller\HHBK_Chemicals\HHBK_Chemicals_ERP_CS\kundenliste.xml");
            
            kunden.Clear();
            foreach (XElement el in doc.Descendants("kunde"))
            {
                Kunde kunde1 = new Kunde();
                kunde1.Kundennummer = Convert.ToInt32(el.Attribute("kundennummer").Value);
                kunde1.Name = el.Element("nachname").Value;
                kunde1.Vorname = el.Element("vorname").Value;
                kunde1.Strasse = el.Element("strasse").Value;
                kunde1.Hausnummer = el.Element("hausnummer").Value;
                kunde1.Ort = el.Element("ort").Value;
                kunde1.Postleitzahl = Convert.ToInt32(el.Element("plz").Value);
                kunde1.Emailadresse = el.Element("email").Value;

                kunden.Add(kunde1);

            }
            
            
        }
    }
}