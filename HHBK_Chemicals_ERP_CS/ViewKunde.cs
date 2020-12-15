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
    public partial class ViewKunde : Form, IViewKunde
    {
        private Kunde kunde;
        private IControllerKunde controllerKunde;
        IControllerKunde IViewKunde.controllerKunde { 
            get => controllerKunde;
            set => controllerKunde=value;
        }

        public ViewKunde()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (textBoxKundennummer.Text == "")
            {
                kunde = new Kunde(
                    0,
                    textBoxName.Text,
                    textBoxVorname.Text,
                    textBoxStrasse.Text,
                    textBoxHausnummer.Text,
                    textBoxOrt.Text,
                    Convert.ToInt32(textBoxPLZ.Text),
                    textBoxEmailadresse.Text);
            }
            else
            {
                kunde = new Kunde(
                    Convert.ToInt32(textBoxKundennummer.Text),
                    textBoxName.Text,
                    textBoxVorname.Text,
                    textBoxStrasse.Text,
                    textBoxHausnummer.Text,
                    textBoxOrt.Text,
                    Convert.ToInt32(textBoxPLZ.Text),
                    textBoxEmailadresse.Text);
            }
            controllerKunde.speichern(kunde);
        }

        private void buttonSuchenKundennummer_Click(object sender, EventArgs e)
        {
            kunde=controllerKunde.suchen(Convert.ToInt32(textBoxKundennummer.Text));
            if (kunde != null)
            {
                textBoxName.Text = kunde.Name;
                textBoxVorname.Text = kunde.Vorname;
                textBoxStrasse.Text = kunde.Strasse;
                textBoxHausnummer.Text = kunde.Hausnummer;
                textBoxPLZ.Text = kunde.Postleitzahl.ToString();
                textBoxOrt.Text = kunde.Ort;
                textBoxEmailadresse.Text = kunde.Emailadresse;
            }
            
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            textBoxKundennummer.Text = "";
            textBoxName.Text = "";
            textBoxVorname.Text = "";
            textBoxStrasse.Text = "";
            textBoxHausnummer.Text = "";
            textBoxPLZ.Text = "";
            textBoxOrt.Text = "";
            textBoxEmailadresse.Text = "";
        }

        private void buttonSucheKundendaten_Click(object sender, EventArgs e)
        {
            
            kunde = controllerKunde.suchen(
                textBoxName.Text,
                textBoxVorname.Text,
                textBoxStrasse.Text,
                textBoxHausnummer.Text,
                textBoxPLZ.Text,
                textBoxOrt.Text,
                textBoxEmailadresse.Text);
            if (kunde != null)
            {
                textBoxName.Text = kunde.Name;
                textBoxVorname.Text = kunde.Vorname;
                textBoxStrasse.Text = kunde.Strasse;
                textBoxHausnummer.Text = kunde.Hausnummer;
                textBoxPLZ.Text = kunde.Postleitzahl.ToString();
                textBoxOrt.Text = kunde.Ort;
                textBoxEmailadresse.Text = kunde.Emailadresse;
            }
            
        }
    }
}
