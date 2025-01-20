using HHBK_Chemicals_ERP_CS.model;

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    public class Kundenliste : IKundenliste
    {
        private List<Kunde> kunden = new List<Kunde>();

        //private string myConnectionString = "server=127.0.0.1;uid=erpModel;pwd=555HHBK;database=HHBK_Chemicals;";
        private MySqlConnection conn=new MySqlConnection("server=127.0.0.1;uid=erpModel;pwd=555HHBK;database=HHBK_Chemicals;");
        private MySqlCommand mycommand;

        public Kundenliste()
        {
            //Prüfen, ob XAMPP läuft
            // -> Sonst Fehlermeldung
            //Prüfen, ob die Datenbank vorhanden ist
            // -> Sonst anlegen
            //Prüfen, ob es Daten gibt
            // -> Sonst anlegen
            this.refresh();
        }

        List<Kunde> IKundenliste.Kunden { get { this.refresh(); return kunden; }}

        void IKundenliste.alter(Kunde kunde)
        {
            if (kunde.Kundennummer != -1)
                mycommand.CommandText = Commands.change(kunde);
            else
                mycommand.CommandText = Commands.newEntity(kunde);

            conn.Open();
            try
            {
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            refresh();
            
        }

        void IKundenliste.delete(Kunde kunde)
        {
            mycommand.CommandText = Commands.delete(kunde);

            conn.Open();
            try
            {
                mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            refresh();
        }
        
        void IKundenliste.save(Kunde kunde)
        {
            if (kunde.Kundennummer != -1)
                mycommand.CommandText = Commands.change(kunde);
            else
                mycommand.CommandText = Commands.newEntity(kunde);

           


            conn.Open();
            try
            {
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            refresh();
        }

        private void refresh()
        {
            kunden.Clear();
            mycommand = conn.CreateCommand();
            mycommand.CommandText = "Select * from kunde";

            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader();

            while (reader.Read())
            {
                Kunde kunde1 = new Kunde();
                kunde1.Kundennummer = Convert.ToInt32(reader["kundennummer"]);
                kunde1.Name = reader["name"].ToString();
                kunde1.Vorname = reader["vorname"].ToString();
                kunde1.Strasse = reader["strasse"].ToString();
                kunde1.Hausnummer = reader["hausnummer"].ToString();
                kunde1.Ort = reader["ort"].ToString();
                kunde1.Postleitzahl = Convert.ToInt32(reader["postleitzahl"]);
                kunde1.Emailadresse = reader["emailadresse"].ToString();

                kunden.Add(kunde1);

            }
            reader.Close();
            conn.Close();
            //kunde1 = new Kunde(kundennummer, name, vorname, strasse, hausnummer, ort, postleitzahl, emailadresse);
        }

  

        Kunde IKundenliste.getKunde(Kunde kunde)
        {
            refresh();
            List<Kunde> kundenResults = kunden;
            Kunde kundeResult = new Kunde();

            if (kunde.Kundennummer != 0)
            {
                foreach (Kunde k in kundenResults)
                {
                    if (k.Kundennummer ==
                        kunde.Kundennummer)
                    {
                        kundeResult.Kundennummer = k.Kundennummer;
                        kundeResult.Name = k.Name;
                        kundeResult.Vorname = k.Vorname;
                        kundeResult.Strasse = k.Strasse;
                        kundeResult.Hausnummer = k.Hausnummer;
                        kundeResult.Ort = k.Ort;
                        kundeResult.Postleitzahl = k.Postleitzahl;
                        kundeResult.Emailadresse = k.Emailadresse;
                    }
                }


            }

            else
            {
                if (kunde.Name != "")
                {

                    kundenResults = kundenResults.FindAll(x => x.Name==kunde.Name);
                }

                if (kunde.Vorname != "")
                {
                    kundenResults = kundenResults.FindAll(x => x.Vorname==kunde.Vorname);
                }

                if (kunde.Strasse != "")
                {
                    kundenResults = kundenResults.FindAll(x => x.Strasse.Contains(kunde.Strasse));
                }

                if (kunde.Hausnummer != "")
                {
                    kundenResults = kundenResults.FindAll(x => x.Hausnummer ==kunde.Hausnummer);
                }

                if (kunde.Postleitzahl != 0)
                {
                    kundenResults = kundenResults.FindAll(x => x.Postleitzahl == kunde.Postleitzahl);
                }

                if (kunde.Ort != "")
                {
                    kundenResults = kundenResults.FindAll(x => x.Ort == kunde.Ort);
                }

                if (kunde.Emailadresse != "")
                {
                    kundenResults = kundenResults.FindAll(x => x.Emailadresse==kunde.Emailadresse);

                }




            }

            if (kundenResults.Count() == 1)
            {
                kundeResult.Kundennummer = Convert.ToInt32(kundenResults.First().Kundennummer);
                kundeResult.Name = kundenResults.First().Name;
                kundeResult.Vorname = kundenResults.First().Vorname;
                kundeResult.Strasse = kundenResults.First().Strasse;
                kundeResult.Hausnummer = kundenResults.First().Hausnummer;
                kundeResult.Ort = kundenResults.First().Ort;
                kundeResult.Postleitzahl = Convert.ToInt32(kundenResults.First().Postleitzahl);
                kundeResult.Emailadresse = kundenResults.First().Emailadresse;
                return kundeResult;
            }


            else if (kundenResults.Count() > 1)
            {
                return kunde;
            }

            else
            {
                return kundeResult;
            }
        }
    
    }
}