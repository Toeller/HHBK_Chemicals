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
    public partial class ViewRezeptverwalten : Form, IViewRezeptverwalten
    {
        private IModel model;
        private IControllerRezeptverwalten controllerRezeptverwalten;
        IModel IViewRezeptverwalten.IModel1 { set => this.model=value; }
        IControllerRezeptverwalten IViewRezeptverwalten.IControllerRezeptverwalten1 { set => this.controllerRezeptverwalten = value; }

        public ViewRezeptverwalten()
        {
            InitializeComponent();
        }

    }
}
