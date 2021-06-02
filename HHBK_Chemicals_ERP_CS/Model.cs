using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HHBK_Chemicals_ERP_CS
{
    class Model:IModel
    {
        private string myConnectionString = "server=127.0.0.1;uid=erpModel;pwd=555HHBK;database=HHBK_Chemicals;";
        private MySqlConnection conn;
        private MySqlCommand mycommand;

        public Model()
        {
            conn = new MySqlConnection(myConnectionString);
            mycommand = conn.CreateCommand();
        }

        IForm1 IModel.IView { set => throw new NotImplementedException(); }
        IController1 IModel.IController1 { set => throw new NotImplementedException(); }

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

        Bestellung IModel.GetBestellung(int bestellnummer)
        {
            throw new NotImplementedException();
        }

        List<int> IModel.getKundennummer()
        {
            List<int> kundennummern=new List<int>();

            mycommand.CommandText = "Select kundennummer from kunde";

            conn.Open();

            MySqlDataReader reader = mycommand.ExecuteReader();

            while (reader.Read())
            {
                kundennummern.Add (Convert.ToInt32(reader["kundennummer"]));
                
            }
            reader.Close();
            conn.Close();
            
            return kundennummern;
        }

        bool IModel.SetBestellung(Bestellung bestellung)
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
            //Kunde kunde1 = null;
            //return kunde1;
        }
    }
}
