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
    // Brauche controller um weiter zu arbeiten//
    public partial class ViewBestellung : Form, IViewBestellung
    {
        int IViewBestellung.Bestellpositionsnummer { get => Convert.ToInt32(Bestellspositions_Textbox.Text); set => Bestellspositions_Textbox.Text = value.ToString() ; }
        public int Bestellungsnummer { get => Convert.ToInt32(Bestellungsnummer_Textbox.Text); set => Bestellungsnummer_Textbox.Text = value.ToString(); }
        public int Mengee { get => Convert.ToInt32(Menge_Textbox.Text); set => Menge_Textbox.Text = value.ToString(); }
        public DateTime Bestelldatum { get => Bestelldatum_Datetimepicker.Value; set => Bestelldatum_Datetimepicker.Value = value; }
        public int Artikelnummer { get => Convert.ToInt32(Artikelnummer_Textbox.Text); set => Artikelnummer_Textbox.Text = value.ToString(); }
        public int Kundennummer { get => Convert.ToInt32(Kundennummer_Textbox.Text); set => Kundennummer_Textbox.Text = value.ToString(); }
        public int Lieferposition { get => Convert.ToInt32(Lieferpositions_Textbox.Text); set => Lieferpositions_Textbox.Text = value.ToString(); }
        public decimal Preis { get => Convert.ToDecimal(Lieferpositions_Textbox.Text); set => Preis_Textbox.Text = value.ToString(); }

        public ViewBestellung()
        {
            InitializeComponent();
        }

        private void OK_button(object sender, EventArgs e)
        {

        }

        private void Neu_button(object sender, EventArgs e)
        {

        }

        private void Löschen_button(object sender, EventArgs e)
        {
            
        }

        private void Bestelldatum_Datetimepicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
