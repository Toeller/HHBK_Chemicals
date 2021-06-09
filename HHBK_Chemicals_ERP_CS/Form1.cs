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
    public partial class Form1 : Form, IForm1
    {
        private IController1 icontroller1;
        private IModel imodel;

        IController1 IForm1.IController1 
        { set => this.icontroller1=value; }
        IModel IForm1.IModel1 { set => this.imodel=value; }

        public Form1()
        {
            InitializeComponent();
            /*foreach (int s in icontroller1.getKundennummern())
                this.comboBoxKundennummer.Items.Add(s);*/

        }
        

    }
    
}
