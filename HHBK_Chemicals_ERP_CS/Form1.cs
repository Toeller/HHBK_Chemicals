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
    public partial class Form1 : Form, IView
    {
        private Kunde angezeigterKunde;
        private Model model;

        Model IView.model { 
            set => this.model=value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            angezeigterKunde=model.getKunde();
        }
    }
}
