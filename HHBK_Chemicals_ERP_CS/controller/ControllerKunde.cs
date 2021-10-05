using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerKunde:IControllerKunde
    {
        private IModel model;
        private IViewKunde viewKunde;

        IViewKunde IControllerKunde.IViewKunde1 { set => this.viewKunde=value; }
        IModel IControllerKunde.IModel1 { set => this.model=value; }
    }
}
