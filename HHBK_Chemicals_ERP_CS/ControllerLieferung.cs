using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerLieferung : IControllerLieferung
    {
        private IModel model;
        private IViewLieferung viewLieferung;

        IModel IControllerLieferung.IModel { set => this.model = value; }
        IViewLieferung IControllerLieferung.IViewLieferung { set => this.viewLieferung = value; }
    }
}
