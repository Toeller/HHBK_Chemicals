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
    public partial class UserControlProduktVerwalten : UserControl
    {
        public UserControlProduktVerwalten()
        {
            InitializeComponent();
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            comboBoxArtikelname.Items.Clear();
            comboBoxArtikelnummer.Items.Clear();
            textBoxVerkaufseinheit.Text = "";
            textBoxEinheit.Text = "";
            textBoxPreisVK.Text = "";
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {

        }
    }
}
