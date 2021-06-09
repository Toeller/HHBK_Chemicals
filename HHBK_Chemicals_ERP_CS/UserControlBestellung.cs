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
        }

        internal List<Bestellung> Bestellungen { get => bestellungenListe;
            set
            {
                //Textboxen füllen
                bestellungenListe = value; 
            }
        }
    }
}
