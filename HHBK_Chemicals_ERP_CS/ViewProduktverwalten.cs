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
    public partial class ViewProduktverwalten : Form, IViewProduktverwalten
    {
        private IControllerProduktverwalten controllerProduktverwalten;
        private IModel model;
        public ViewProduktverwalten()
        {
            InitializeComponent();
        }

        IModel IViewProduktverwalten.IModel1 { set => this.model=value; }
        IControllerProduktverwalten IViewProduktverwalten.IControllerProduktverwalten1 { set => this.controllerProduktverwalten=value; }
    }
}
