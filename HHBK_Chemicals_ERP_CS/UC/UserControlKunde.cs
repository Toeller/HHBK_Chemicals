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

        private int index = 0;
        
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

        public int Index { get => index;
            set
            {
                if (value< KundenListe.Count && value>=0)
                {
                    index = value;
                }

                textBoxKundennummer.Text = Convert.ToString(kundenListe[Index].Kundennummer);
                textBoxName.Text = kundenListe[Index].Name;
                textBoxVorname.Text = kundenListe[Index].Vorname;
                textBoxStrasse.Text = kundenListe[Index].Strasse;
                textBoxHausnummer.Text = kundenListe[Index].Hausnummer;
                textBoxPLZ.Text = Convert.ToString(kundenListe[Index].Postleitzahl);
                textBoxOrt.Text = kundenListe[Index].Ort;
                textBoxEmailadresse.Text = kundenListe[Index].Emailadresse;
                setKunde();

            }
        }

        public Kunde Kunde
        {
            get => kunde;
            set
            {
                kunde = value;

                textBoxKundennummer.Text = Convert.ToString(kunde.Kundennummer);
                textBoxName.Text = kunde.Name;
                textBoxVorname.Text = kunde.Vorname;
                textBoxStrasse.Text = kunde.Strasse;
                textBoxHausnummer.Text = kunde.Hausnummer;
                textBoxPLZ.Text = Convert.ToString(kunde.Postleitzahl);
                textBoxOrt.Text = kunde.Ort;
                textBoxEmailadresse.Text = kunde.Emailadresse;
            }
        }

        public event EventHandler UCKundeAendern;
        public event EventHandler UCKundeLoeschen;
        public event EventHandler UCKundeSuchen;

        protected virtual void OnUCKundeSuchen(object sender, EventArgs e)
        {
            EventHandler handler = UCKundeSuchen;
            handler?.Invoke(this, e);
        }
        protected virtual void OnUCKundeAendern(object sender, EventArgs e)
        {
            EventHandler handler = UCKundeAendern;
            handler?.Invoke(this, e);
        }

        protected virtual void OnUCKundeLoeschen(object sender, EventArgs e)
        {
            EventHandler handler = UCKundeLoeschen;
            handler?.Invoke(this, e);
        }


        private void buttonNeu_Click(object sender, EventArgs e)
        {
            if (buttonAendern.Text != "speichern")
            {
                textBoxKundennummer.ReadOnly = true;
                textBoxKundennummer.Text = "";
                textBoxName.Text = "";
                textBoxVorname.Text = "";
                textBoxStrasse.Text = "";
                textBoxHausnummer.Text = "";
                textBoxPLZ.Text = "";
                textBoxOrt.Text = "";
                textBoxEmailadresse.Text = "";

                buttonAendern.Text = "speichern";
                buttonNeu.Text = "abbrechen";
                buttonLoeschen.Visible = false;
                
            }

            else
            {
                textBoxKundennummer.ReadOnly = false;

                Index = 0;

                buttonAendern.Text = "ändern";
                buttonNeu.Text = "neu";
                buttonLoeschen.Visible = true;
                
            }

        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            
            
            setKunde();
            OnUCKundeAendern(this, e);
            Index = 0; //Besser Index auf geändertes/neues Element legen!!!
            buttonAendern.Text = "ändern";
            buttonNeu.Text = "neu";
            buttonLoeschen.Visible = true;

        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            Index++;
        }

        private void buttonBackwards_Click(object sender, EventArgs e)
        {
            Index--;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            Index=0;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            Index = KundenListe.Count-1;
        }

        private void setKunde()
        {
            if (buttonAendern.Text == "ändern")
                Kunde.Kundennummer = Convert.ToInt32(textBoxKundennummer.Text);
            else if (buttonAendern.Text == "speichern")
                Kunde.Kundennummer = -1;

            Kunde.Name = textBoxName.Text;
            Kunde.Vorname = textBoxVorname.Text;
            Kunde.Strasse = textBoxStrasse.Text;
            Kunde.Hausnummer = textBoxHausnummer.Text;
            try
            {
                Kunde.Postleitzahl = Convert.ToInt32(textBoxPLZ.Text);
            }
            catch
            {
                Kunde.Postleitzahl = 0;
            }
            Kunde.Ort = textBoxOrt.Text;
            Kunde.Emailadresse = textBoxEmailadresse.Text;
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            OnUCKundeLoeschen(this, e);
            Index = 0;
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            if (buttonSuchen.Text == "suchen")
            {
                textBoxKundennummer.ReadOnly = false;
              
                textBoxKundennummer.Text = "";
                textBoxName.Text = "";
                textBoxVorname.Text = "";
                textBoxStrasse.Text = "";
                textBoxHausnummer.Text = "";
                textBoxPLZ.Text = "";
                textBoxOrt.Text = "";
                textBoxEmailadresse.Text = "";

                buttonSuchen.Text = "abbrechen";

                buttonLoeschen.Visible = false;
                buttonAendern.Visible = false;
            }
            else
            {
                buttonSuchen.Text = "suchen";

                buttonLoeschen.Visible = true;
                buttonAendern.Visible = true;
                textBoxKundennummer.ReadOnly = true;
                Index = 0;
            }
        }

        private void textBoxKundennummer_Validated(object sender, EventArgs e)
        {
            if(buttonSuchen.Text=="abbrechen")
            {
                setKunde();
                OnUCKundeSuchen(this, e);

                textBoxKundennummer.Text = kunde.Kundennummer.ToString();
                textBoxName.Text = kunde.Name;
                textBoxVorname.Text = kunde.Vorname;
                textBoxStrasse.Text = kunde.Strasse;
                textBoxHausnummer.Text = kunde.Hausnummer;
                textBoxPLZ.Text = Convert.ToString(kunde.Postleitzahl);
                textBoxOrt.Text = kunde.Ort;
                textBoxEmailadresse.Text = kunde.Emailadresse;
            }
        }
    }
}
