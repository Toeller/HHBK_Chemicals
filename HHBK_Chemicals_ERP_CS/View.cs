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
    public partial class View : Form, IView
    {
        private IModel model;
        private IController controller;
        public View()
        {
            InitializeComponent();
        }

        IModel IView.IModel1 { set => this.model=value; }
        IController IView.IController1 { set => this.controller=value; }
    }
}
