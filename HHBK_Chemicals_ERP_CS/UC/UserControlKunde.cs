using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    public partial class UserControlKunde : UserControl
    {
        private List<Kunde> kundenListe = new List<Kunde>();

        private Kunde kunde = new Kunde();
        public UserControlKunde()
        {
            InitializeComponent();
        }

        internal List<Kunde> KundenListe
        {
            get => kundenListe;
            set
            {
                kundenListe = value;
                textBoxKundennummer.Text = Convert.ToString(kundenListe[0].Kundennummer);
                textBoxName.Text = kundenListe[0].Name;
                textBoxVorname.Text = kundenListe[0].Vorname;
                textBoxStrasse.Text = kundenListe[0].Strasse;
                textBoxHausnummer.Text = kundenListe[0].Hausnummer;
                textBoxPLZ.Text = Convert.ToString(kundenListe[0].Postleitzahl);
                textBoxOrt.Text = kundenListe[0].Ort;
                textBoxEmailadresse.Text = kundenListe[0].Emailadresse;


            }
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            textBoxKundennummer.Enabled = false;
            textBoxKundennummer.Text = "";
            textBoxName.Text = "";
            textBoxVorname.Text = "";
            textBoxStrasse.Text = "";
            textBoxHausnummer.Text = "";
            textBoxPLZ.Text = "";
            textBoxOrt.Text = "";
            textBoxEmailadresse.Text = "";

            buttonAendern.Text = "speichern";
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            /*
            if (buttonAendern.Text == "ändern")
                kunde.Artikelnummer = Convert.ToInt32(comboBoxArtikelnummer.SelectedItem.ToString());
            else if (buttonAendern.Text == "speichern")
                Produkt.Artikelnummer = -1;
            Produkt.Artikelname = comboBoxArtikelname.Text;
            Produkt.PreisVK = Convert.ToDouble(textBoxPreisVK.Text);
            Produkt.Verkaufseinheit = Convert.ToInt32(textBoxVerkaufseinheit.Text);
            Produkt.Einheit = textBoxEinheit.Text;
            Produkt.ChemischeBezeichnung = textBoxChemischeBezeichnung.Text;

            buttonAendern.Text = "ändern";
            comboBoxArtikelnummer.Enabled = true;
            //MessageBox.Show(Produkt.Artikelname + " " + produkt.ChemischeBezeichnung);

            OnUCKundeAendern(this, e);

            */
        }
    }
}
