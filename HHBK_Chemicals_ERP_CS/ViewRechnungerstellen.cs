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
    public partial class ViewRechnungerstellen : Form,IViewRechnungerstellen
    {
        private int rechnungspositionsnummer;
        private int rechnungsnummer;
        private int bestellpositionsnummer;
        private int artikelnummer;
        private int kundennummer;

        public int Rechnungspositionsnummer { get => rechnungspositionsnummer; set => rechnungspositionsnummer = value; }
        public int Rechnungsnummer { get => rechnungsnummer; set => rechnungsnummer = value; }
        public int Bestellpositionsnummer { get => bestellpositionsnummer; set => bestellpositionsnummer = value; }
        public int Artikelnummer { get => artikelnummer; set => artikelnummer = value; }
        public int Kundennummer { get => kundennummer; set => kundennummer = value; }

        public ViewRechnungerstellen()
        {
            InitializeComponent();
        }

        private void txtRechnungspositionsnummer_Click(object sender, EventArgs e)
        {

        }

        private void ViewRechnungerstellen_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxRechnungspositionsnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRechnungerstellen_Click(object sender, EventArgs e)
        {

        }

        void IViewRechnungerstellen.Rechnungsdatenspeichern()
        {
            Rechnungspositionsnummer = Convert.ToInt32(txtBoxRechnungspositionsnummer.Text);
            Rechnungsnummer = Convert.ToInt32(txtBoxRechnungsnummer.Text);
            Bestellpositionsnummer = Convert.ToInt32(txtBoxBestellpositionsnummer.Text);
            Artikelnummer = Convert.ToInt32(txtBoxArtikelnummer.Text);
            Kundennummer = Convert.ToInt32(txtBoxKundennummer.Text);

        }
    }
}
