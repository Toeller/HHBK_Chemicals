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
    public partial class Kundenverwaltung : Form
    {
        List<Kunde> kundenliste;
        Model model;
        public Kundenverwaltung()
        {
            InitializeComponent();
            //kundenliste = model.getKunde();
        }

        public void init()
        {
            textBoxKundeKundennummer.Text = Convert.ToString(kundenliste.First().Kundennummer);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
