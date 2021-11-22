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
        private string fileName="kundenliste.xml";

        public KundenlisteXML()
        {
            this.generate();
            this.refresh();
        }

        List<Kunde> IKundenliste.Kunden { get { this.refresh(); return kunden; }}

        void IKundenliste.alter(Kunde kunde)
        {
            doc = XDocument.Load(@"kundenliste.xml");

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

            doc.Save(@"kundenliste.xml");

            refresh();
        }

        void IKundenliste.delete(Kunde kunde)
        {
            doc = XDocument.Load(@"kundenliste.xml");

           
            
            doc.Descendants("kunde").
                Where(
                        element =>
                        element.Attribute("kundennummer").Value == kunde.Kundennummer.ToString()
                      ).Remove();
            doc.Save("kundenliste.xml");
            refresh();
        }

        void IKundenliste.save(Kunde kunde)
        {
            doc = XDocument.Load(@"kundenliste.xml");

            int kundennummer=0;
            foreach(XElement el in doc.Descendants("kunde"))
            {
                if (Convert.ToInt32(el.Attribute("kundennummer").Value) > kundennummer)
                    kundennummer = Convert.ToInt32(el.Attribute("kundennummer").Value);
            }

            kundennummer++;


            doc.Descendants("kunde").
                Where(
                        element =>
                        Convert.ToInt32(element.Attribute("kundennummer").Value) < kundennummer).
                        Last().AddAfterSelf(
                            new XElement("kunde",
                                new XAttribute("kundennummer", kundennummer.ToString()),
                                new XElement("nachname", kunde.Name),
                                new XElement("vorname", kunde.Vorname),
                                new XElement("strasse", kunde.Strasse),
                                new XElement("hausnummer", kunde.Hausnummer),
                                new XElement("plz", kunde.Postleitzahl.ToString()),
                                new XElement("ort", kunde.Ort),
                                new XElement("email", kunde.Emailadresse)
            ));
            doc.Save("kundenliste.xml");

            refresh();
        }

        Kunde IKundenliste.getKunde(int kundennummer)
        {
            Kunde kunde = new Kunde();
            doc = XDocument.Load(fileName);
            //.Where(
            //element => element.Attribute("kundennummer").Value == kundennummer.ToString())
            foreach (XElement el in doc.Descendants("kunde"))
            {
                if (Convert.ToInt32(el.Attribute("kundennummer").Value) == kundennummer)
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
            }

            return kunde;
        }

        Kunde IKundenliste.getKunde(Kunde kunde)
        {
            Kunde kundeResult = new Kunde();
            IEnumerable<XElement> kundenResults=doc.Descendants("Kunde");
            doc = XDocument.Load(fileName);
            kundenResults=doc.Descendants("kunde");

            

            if (kunde.Kundennummer != 0)
            {
                foreach (XElement el in kundenResults)
                {
                    if (Convert.ToInt32(el.Attribute("kundennummer").Value) ==
                        kunde.Kundennummer)
                    {
                        kundeResult.Kundennummer = Convert.ToInt32(el.Attribute("kundennummer").Value);
                        kundeResult.Name = el.Element("nachname").Value;
                        kundeResult.Vorname = el.Element("vorname").Value;
                        kundeResult.Strasse = el.Element("strasse").Value;
                        kundeResult.Hausnummer = el.Element("hausnummer").Value;
                        kundeResult.Ort = el.Element("ort").Value;
                        kundeResult.Postleitzahl = Convert.ToInt32(el.Element("plz").Value);
                        kundeResult.Emailadresse = el.Element("email").Value;
                    }
                }

                return kundeResult;
            }

            else
            {
                if(kunde.Name!="")
                {
                    
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("nachname").Value) == kunde.Name);
                }

                if (kunde.Vorname!="")
                {
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("vorname").Value) == kunde.Vorname);
                }

                if (kunde.Strasse != "") 
                {
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("strasse").Value) == kunde.Strasse);
                }

                if(kunde.Hausnummer!="")
                {
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("hausnummer").Value) == kunde.Hausnummer);
                }

                if(kunde.Postleitzahl!=0)
                {
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("plz").Value) == Convert.ToString(kunde.Postleitzahl));
                }

                if(kunde.Ort!="")
                {
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("ort").Value) == kunde.Ort);
                }

                if(kunde.Emailadresse!="")
                {
                    kundenResults = kundenResults.
                        Where(element =>
                            (element.Element("email").Value) == kunde.Emailadresse);

                }

                if(kundenResults.Count()==1)
                {
                    kundeResult.Kundennummer =Convert.ToInt32(kundenResults.First().Attribute("kundennummer").Value);
                    kundeResult.Name = kundenResults.First().Element("nachname").Value;
                    kundeResult.Vorname = kundenResults.First().Element("vorname").Value;
                    kundeResult.Strasse = kundenResults.First().Element("strasse").Value;
                    kundeResult.Hausnummer = kundenResults.First().Element("hausnummer").Value;
                    kundeResult.Ort = kundenResults.First().Element("ort").Value;
                    kundeResult.Postleitzahl = Convert.ToInt32(kundenResults.First().Element("plz").Value);
                    kundeResult.Emailadresse = kundenResults.First().Element("email").Value;
                    return kundeResult;
                }
                else if(kundenResults.Count()>1)
                {
                    return kunde;
                }

                else 
                {
                    return kundeResult;
                }
            }
        }


        void refresh()
        {
            XDocument doc = XDocument.Load(fileName);
            
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

        void IKundenliste.generate()
        {
            try
            {
                doc = XDocument.Load(fileName);
            }
            catch
            {


                doc = new XDocument(new XElement("kundenliste",
                                        new XElement("kunde",
                                            new XAttribute("kundennummer", "1"),
                                            new XElement("nachname", "Lichtleitner"),
                                            new XElement("vorname", "Alexander"),
                                            new XElement("strasse", "Steinstrasse"),
                                            new XElement("hausnummer", "12"),
                                            new XElement("plz", "40225"),
                                            new XElement("ort", "Düsseldorf"),
                                            new XElement("email", "LichtleitnerAlexander@test-subjet.ru")
                                                    ),
                                        new XElement("kunde",
                                            new XAttribute("kundennummer", "3"),
                                            new XElement("nachname", "Autrum"),
                                            new XElement("vorname", "Maximilian"),
                                            new XElement("strasse", "Am Ackerweg"),
                                            new XElement("hausnummer", "4"),
                                            new XElement("plz", "20764"),
                                            new XElement("ort", "Hamburg"),
                                            new XElement("email", "AurtumMaximilian@test-subjet.ru")
                                                    ),
                                        new XElement("kunde",
                                            new XAttribute("kundennummer", "61"),
                                            new XElement("nachname", "Schwarz"),
                                            new XElement("vorname", "Dominik"),
                                            new XElement("strasse", "Am BergischWeg"),
                                            new XElement("hausnummer", "20c"),
                                            new XElement("plz", "90668"),
                                            new XElement("ort", "Ansbach"),
                                            new XElement("email", "SchwarzDominik@test-subjet.ru")
                                                    )

                                                )
                                 );
                doc.Save(fileName);
            }
        }

        void generate()
        {
            try
            {
                doc = XDocument.Load(fileName);
            }
            catch
            {


                doc = new XDocument(new XElement("kundenliste",
                                        new XElement("kunde",
                                            new XAttribute("kundennummer", "1"),
                                            new XElement("nachname", "Lichtleitner"),
                                            new XElement("vorname", "Alexander"),
                                            new XElement("strasse", "Steinstrasse"),
                                            new XElement("hausnummer", "12"),
                                            new XElement("plz", "40225"),
                                            new XElement("ort", "Düsseldorf"),
                                            new XElement("email", "LichtleitnerAlexander@test-subjet.ru")
                                                    ),
                                        new XElement("kunde",
                                            new XAttribute("kundennummer", "3"),
                                            new XElement("nachname", "Autrum"),
                                            new XElement("vorname", "Maximilian"),
                                            new XElement("strasse", "Am Ackerweg"),
                                            new XElement("hausnummer", "4"),
                                            new XElement("plz", "20764"),
                                            new XElement("ort", "Hamburg"),
                                            new XElement("email", "AurtumMaximilian@test-subjet.ru")
                                                    ),
                                        new XElement("kunde",
                                            new XAttribute("kundennummer", "61"),
                                            new XElement("nachname", "Schwarz"),
                                            new XElement("vorname", "Dominik"),
                                            new XElement("strasse", "Am BergischWeg"),
                                            new XElement("hausnummer", "20c"),
                                            new XElement("plz", "90668"),
                                            new XElement("ort", "Ansbach"),
                                            new XElement("email", "SchwarzDominik@test-subjet.ru")
                                                    )

                                                )
                                 );
                doc.Save(fileName);
            }
        }
    }
}