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
    public partial class ViewLieferung : Form, IViewLieferung
    {
        private IModel model;
        private IControllerLieferung controllerLieferung;

        IModel IViewLieferung.IModel1 { set => this.model=value; }
        IControllerLieferung IViewLieferung.IControllerlieferung1 { set => this.controllerLieferung=value; }

        public ViewLieferung()
        {
            InitializeComponent();
        }

    }
}
