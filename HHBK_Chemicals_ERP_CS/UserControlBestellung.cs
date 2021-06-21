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
    public partial class UserControlBestellung : UserControl
    {
        List<Bestellung> bestellungenListe = new List<Bestellung>();
        public UserControlBestellung()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        internal List<Bestellung> Bestellungen { get => bestellungenListe;
            set
            {
                foreach (Bestellung b in Bestellungen)
                    dataGridView1.Rows.Add(b.Bestellpositionsnummer, b.Menge, b.Produkt.Artikelnummer, b.Produkt.Artikelname, b.Produkt.Verkaufseinheit, b.Produkt.PreisVK, b.Menge * b.Produkt.PreisVK);
                bestellungenListe = value; 
            }
        }

        private void t(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
