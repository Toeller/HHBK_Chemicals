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
    public partial class ViewProduktion : Form, IViewProduktion
    {
        public ViewProduktion()
        {
            InitializeComponent();
        }

        private void buttonSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelName_Produzent_Click(object sender, EventArgs e)
        {

        }

        
    }
}
