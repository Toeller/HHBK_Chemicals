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
    public partial class ViewLagereingang : Form, IViewLagereingang
    {
        private IModel model;
        private IControllerLagereingang controllerLagereingang;

        IModel IViewLagereingang.IModel1 { set => this.model = value; }
        IControllerLagereingang IViewLagereingang.IControllerLagereingang1 { set => throw new NotImplementedException(); }

        public ViewLagereingang()
        {
            InitializeComponent();
        }

    }
}
