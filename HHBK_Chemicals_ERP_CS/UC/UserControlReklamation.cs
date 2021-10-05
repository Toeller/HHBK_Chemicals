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
    public partial class UserControlReklamation : UserControl
    {
        List<Reklamation> reklamationen = new List<Reklamation>();
        public UserControlReklamation()
        {
            InitializeComponent();
        }

        internal List<Reklamation> Reklamationen { get => reklamationen; set => reklamationen = value; }
    }
}
