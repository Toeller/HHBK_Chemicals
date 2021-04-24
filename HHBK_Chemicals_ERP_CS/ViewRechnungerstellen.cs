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
    public partial class ViewRechnungerstellen : Form, IViewRechnungerstellen
    {
        private IModel model;
        private IControllerRechnungerstellen controllerRechnungerstellen;

        IModel IViewRechnungerstellen.IModel1 { set => this.model=value; }
        IControllerRechnungerstellen IViewRechnungerstellen.IControllerRechnungerstellen1 { set => this.controllerRechnungerstellen=value; }

        public ViewRechnungerstellen()
        {
            InitializeComponent();
        }

    }
}
