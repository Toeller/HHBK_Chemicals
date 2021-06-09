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
    public partial class UserControlLagereingang : UserControl
    {
        private List<Lagerposition> lagerpositionen= new List<Lagerposition>();
        public UserControlLagereingang()
        {
            InitializeComponent();
        }

        public List<Lagerposition> Lagerpositionen
        {
            get => lagerpositionen;
            set
            {
                //Boxen füllen
                lagerpositionen = value;
            }
        }
    }
}
