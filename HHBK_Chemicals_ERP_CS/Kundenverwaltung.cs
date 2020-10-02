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
        Kunde kunde1;
        Model model;
        public Kundenverwaltung()
        {
            InitializeComponent();
            kunde1 = model.getKunde();
        }

        public void init()
        {
            textBoxKundeKundennummer.Text = Convert.ToString(kunde1.Kundennummer);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
