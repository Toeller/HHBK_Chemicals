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
    public partial class ViewReklamation : Form, IViewReklamation
    {
        private IModel model;
        private IControllerReklamation controllerReklamation;

        IModel IViewReklamation.IModel1 { set => this.model=value; }
        IControllerReklamation IViewReklamation.IControllerReklamation1 { set => this.controllerReklamation=value; }

        public ViewReklamation()
        {
            InitializeComponent();
        }

    }
}
