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
        List<Produktionsliste> produktionslisten = new List<Produktionsliste>();
        

        internal List<Produktionsliste> Produktionslisten {
            get => produktionslisten;
            set
            {
                produktionslisten = value;
                textBoxProduktionspositionsnummer.Text = produktionslisten[0].ToString();
                //textBoxBestellpositionsnummer.Text =;
            }
        }
        
        public event EventHandler ProduktionFreigegeben;
        public UserControlProduktion()
        {
            InitializeComponent();
        }
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
