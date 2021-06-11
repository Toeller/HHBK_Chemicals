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
    public partial class UserControlLieferung : UserControl
    {
        private List<Bestellung> bestellungen;

        public UserControlLieferung()
        {
            InitializeComponent();
        }

        internal List<Bestellung> Bestellungen
        {
            get => bestellungen;
            set
            {
                bestellungen = value;
                textBoxLiefernummer.Text = bestellungen[0].Lieferung.Liefernummer;
                textBoxVersanddatum.Text = bestellungen[0].Lieferung.Versanddatum.ToString();
                textBoxLieferdatum.Text = bestellungen[0].Lieferung.Lieferdatum.ToString();
                textBoxNameSpedition.Text = bestellungen[0].Lieferung.NameSpedition;

                textBoxBestellnummer.Text = bestellungen[0].Bestellungsnummer.ToString();
                textBoxKundennummer.Text = bestellungen[0].Kunde.Kundennummer.ToString();
                textBoxName.Text = bestellungen[0].Kunde.Name;
                textBoxVorname.Text = bestellungen[0].Kunde.Vorname;
                textBoxStrasse.Text = bestellungen[0].Kunde.Strasse;
                textBoxHausnummer.Text = bestellungen[0].Kunde.Hausnummer;
                textBoxPostleitzahl.Text = bestellungen[0].Kunde.Postleitzahl.ToString();
                textBoxOrt.Text = bestellungen[0].Kunde.Ort;
            }
        }
    }
}
