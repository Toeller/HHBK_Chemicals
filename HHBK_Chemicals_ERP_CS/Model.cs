using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HHBK_Chemicals_ERP_CS
{
    class Model:IModel
    {
        //private string myConnectionString = "server=127.0.0.1;uid=erpModel;pwd=555HHBK;database=HHBK_Chemicals;";
        private string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=HHBK_Chemicals;";
        private MySqlConnection conn;
        private MySqlCommand mycommand;

        public Model()
        {
            conn = new MySqlConnection(myConnectionString);
            mycommand = conn.CreateCommand();
        }

      
        public Kunde getKunde()
        {
            Kunde kunde1 = null;
            int kundennummer=0;
            string name="NN";
            string vorname="NN";
            string strasse="NN";
            string hausnummer="NN";
            string ort="NN";
            int postleitzahl=0;
            string emailadresse="NN";


           
           
            mycommand.CommandText = "Select * from kunde";
            
            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader(); 
            
            while (reader.Read())
            {
                kundennummer    = Convert.ToInt32(reader["kundennummer"]);
                name         = reader["name"].ToString();
                vorname      = reader["vorname"].ToString();
                strasse = reader["strasse"].ToString();
                hausnummer = reader["hausnummer"].ToString();
                ort = reader["ort"].ToString();
                postleitzahl    = Convert.ToInt32(reader["postleitzahl"]);
                emailadresse = reader["emailadresse"].ToString();
            }
            reader.Close();
            conn.Close();
            kunde1 = new Kunde(kundennummer, name, vorname, strasse, hausnummer, ort, postleitzahl, emailadresse);

            return kunde1;
        }

        bool IModel.BestellpositionAnlegen(int Bestellpositionsnummer, int Bestellungsnummer, int Menge, DateTime Bestelldatum, int Artikelnummer, int Kundennummer, int idLieferposition)
        {
            throw new NotImplementedException();
        }

        bool IModel.createDB()
        {
            try
            {
                mycommand.CommandText = Commands.createDatabase;

                conn.Open();
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;

        }

        bool IModel.KundeAnlegen(int Kundennummer, string Name, string Vorname, string Strasse, int Hausnummer, int Postleitzahl, string Ort, string emaliadresse, string password)
        {
            throw new NotImplementedException();
        }

        bool IModel.LagerpositionAnlegen(int Lagerpositionsnummer, string Grundstoffname, int Grundstoffmenge, string Gundstoffeinheit)
        {
            throw new NotImplementedException();
        }

        bool IModel.Lagerposition_has_RezeptAnlegen(int Lagerpositionsnummer, int Rezept_Rezeptnummer, int Menge, string Einheit)
        {
            throw new NotImplementedException();
        }

        bool IModel.LieferpositionAnlegen(int idLieferposition, string Liefernummer, DateTime Versanddatum, DateTime Lieferdatum, string NameVersandkontrolle, string NameSpedition)
        {
            throw new NotImplementedException();
        }

        bool IModel.ProduktAnlegen(int Artikelnummer, string Artikelname, int Verkaufseinheit, string Einheit, double PreisVK)
        {
            throw new NotImplementedException();
        }

        bool IModel.ProduktionsplanAnlegen(int Produktionsplannummer, DateTime StartSoll, DateTime StartIst, int Rezeptnummer, int Produktionspositionsnummer, int Bestellpositionsnummer, int Kundennummer)
        {
            throw new NotImplementedException();
        }

        bool IModel.ProduktionspositionAnlegen(int Produktionspositionsnummer, int Artikelnummer, DateTime DatumProduktionsfreigabe, DateTime DatumProduktion, string NameProdkutionsfreigabe, string NameProduzent, int Bestellpositionsnummer, int Kundennummer)
        {
            throw new NotImplementedException();
        }

        bool IModel.RechnungspositionAnlegen(int Rechnungspositionsnummer, int Rechnungsnummer, int Bestellpositionsnummer, int Artikelnummer, int Kundennummer)
        {
            throw new NotImplementedException();
        }

        bool IModel.RezeptAnlegen(int Rezeptnummer, int HerstellungsdauerMin, int Artikelnummer)
        {
            throw new NotImplementedException();
        }

        private void testen()
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=test;";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            MySqlCommand mycommand = conn.CreateCommand();
            mycommand.CommandText = "Select * from testtabelle"; conn.Open();

            //mycommand.CommandText = "Insert into testtabelle values(NULL,'" + textBoxName.Text.ToString() + "','" + textBoxVorname.Text.ToString() + "')";

            MySqlDataReader reader = mycommand.ExecuteReader(); while (reader.Read())
            {
            //label1.Text = reader["testTabelleID"].ToString();
            }
            //Datenbank -> Kunde holen
            Kunde kunde1 = null;
            //return kunde1;
        }

        bool IModel.ZahlungseingangAnlegen(int Zahlungseingangsnummer, string VerwendungszweckKdNr, string VerwendungszweckBestNr, DateTime Datum, string NameKontoinhaber, string IBAN, int Kundennummer)
        {
            throw new NotImplementedException();
        }
    }
}
