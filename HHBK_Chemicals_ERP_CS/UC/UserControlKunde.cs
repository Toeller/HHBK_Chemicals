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

        private Kunde kundeNeu = new Kunde();

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

                kundeNeu.Kundennummer = kundenListe[Index].Kundennummer;
                kundeNeu.Name = kundenListe[Index].Name;
                kundeNeu.Vorname = kundenListe[Index].Vorname;
                kundeNeu.Strasse = kundenListe[Index].Strasse;
                kundeNeu.Hausnummer = kundenListe[Index].Hausnummer;
                kundeNeu.Postleitzahl = kundenListe[Index].Postleitzahl;
                kundeNeu.Ort = kundenListe[Index].Ort;
                kundeNeu.Emailadresse = kundenListe[Index].Emailadresse;
                Kunde = kundeNeu;

            }
        }

        public Kunde Kunde
        {
            get => kunde;
            set
            {
                kunde = value;
                if (value.Kundennummer == 0)
                {
                    textBoxKundennummer.Text = "";
                    textBoxKundennummer.BackColor = Color.Red;
                }
                else
                {
                    textBoxKundennummer.Text = Convert.ToString(value.Kundennummer);
                    textBoxKundennummer.BackColor = Color.White;
                }

                if (value.Name == "")
                    textBoxName.BackColor = Color.Red;
                else
                {
                    textBoxName.BackColor = Color.White;
                    textBoxName.Text = value.Name;
                }

                if (value.Vorname == "")
                    textBoxVorname.BackColor = Color.Red;
                else
                {
                    textBoxVorname.BackColor = Color.White;
                    textBoxVorname.Text = value.Vorname;
                }

                if (value.Strasse == "")
                    textBoxStrasse.BackColor = Color.Red;
                else
                {
                    textBoxStrasse.BackColor = Color.White;
                    textBoxStrasse.Text = value.Strasse;
                }

                if (value.Hausnummer == "")
                    textBoxHausnummer.BackColor = Color.Red;
                else
                {
                    textBoxHausnummer.BackColor = Color.White;
                    textBoxHausnummer.Text = value.Hausnummer;
                }
                
                if(value.Postleitzahl==0)
                {
                    textBoxPLZ.Text = "";
                    textBoxPLZ.BackColor = Color.Red;
                }
                else
                {
                    textBoxPLZ.Text = Convert.ToString(value.Postleitzahl);
                    textBoxPLZ.BackColor = Color.White;
                }

                if (value.Ort == "")
                    textBoxOrt.BackColor = Color.Red;
                else
                {
                    textBoxOrt.BackColor = Color.White;
                    textBoxOrt.Text = value.Ort;
                }

                if (value.Emailadresse=="")
                    textBoxEmailadresse.BackColor = Color.Red;
                else
                {
                    textBoxEmailadresse.BackColor = Color.White;
                    textBoxEmailadresse.Text = value.Emailadresse;
                }


                
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
                buttonSuchen.Visible = false;
                buttonLast.Visible = false;
                buttonBackwards.Visible = false;
                buttonForward.Visible = false;
                buttonFirst.Visible = false;

            }

            else
            {
                textBoxKundennummer.ReadOnly = false;

                Index = 0;

                buttonAendern.Text = "ändern";
                buttonNeu.Text = "neu";
                buttonLoeschen.Visible = true;
                buttonSuchen.Visible = true;
                buttonLast.Visible = true;
                buttonBackwards.Visible = true;
                buttonForward.Visible = true;
                buttonFirst.Visible = true;

            }

        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            
            
            uebernehmeKundeAusFormular();
            OnUCKundeAendern(this, e);
            Index = 0; //Besser Index auf geändertes/neues Element legen!!!
            
            buttonAendern.Text = "ändern";
            buttonNeu.Text = "neu";

            buttonLoeschen.Visible = true;
            buttonSuchen.Visible = true;
            buttonLast.Visible = true;
            buttonBackwards.Visible = true;
            buttonForward.Visible = true;
            buttonFirst.Visible = true;

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

        private void uebernehmeKundeAusFormular()
        {
            if (buttonAendern.Text == "ändern")
            {
                try
                {
                    Kunde.Kundennummer = Convert.ToInt32(textBoxKundennummer.Text);
                }
                catch
                {
                    Kunde.Kundennummer = 0;
                }

            }
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
                buttonNeu.Visible = false;
                buttonLast.Visible = false;
                buttonBackwards.Visible = false;
                buttonForward.Visible = false;
                buttonFirst.Visible = false;
            }
            else
            {
                buttonSuchen.Text = "suchen";

                buttonLoeschen.Visible = true;
                buttonAendern.Visible = true;
                buttonNeu.Visible = true;
                buttonLast.Visible = true;
                buttonBackwards.Visible = true;
                buttonForward.Visible = true;
                buttonFirst.Visible = true;
                textBoxKundennummer.ReadOnly = true;
                Index = 0;
            }
        }

       private void textBox_Validated(object sender, EventArgs e)
        {
            if (buttonSuchen.Text == "abbrechen")
            {
                uebernehmeKundeAusFormular();
                OnUCKundeSuchen(this, e);
            }
        }
    }
}
