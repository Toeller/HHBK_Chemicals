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
    public partial class ViewZahlungseingangpruefen : Form, IViewZahlungseingangpruefen
    {
        private IModel model;
        private IControllerZahlungseingangpruefen controllerZahlungseingangpruefen;
        IModel IViewZahlungseingangpruefen.IModel1 { set => this.model = value; }
        IControllerZahlungseingangpruefen IViewZahlungseingangpruefen.IControllerZahlungseingangpruefen1 { set => this.controllerZahlungseingangpruefen=value; }

        public ViewZahlungseingangpruefen()
        {
            InitializeComponent();
        }

    }
}
