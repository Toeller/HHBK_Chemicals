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
    public partial class UserControlProduktion : UserControl
    {
        public UserControlProduktion()
        {
            InitializeComponent();
        }

        public event EventHandler ProduktionFreigegeben;

        protected virtual void OnProduktionFreigegeben(EventArgs e)
        {
            EventHandler handler = ProduktionFreigegeben;
            handler?.Invoke(this, e);
        }

        private void buttonProduktionsfreigabe_Click(object sender, EventArgs e)
        {
            OnProduktionFreigegeben(e);
        }
    }
}
