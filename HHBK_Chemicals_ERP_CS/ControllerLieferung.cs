using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerLieferung:IControllerLieferung
    {
        private IModel model;
        private IViewLieferung viewLieferung;

        IViewLieferung IControllerLieferung.IViewLieferung1 { set => this.viewLieferung=value; }
        IModel IControllerLieferung.IModel1 { set => this.model=value; }
    }
}
