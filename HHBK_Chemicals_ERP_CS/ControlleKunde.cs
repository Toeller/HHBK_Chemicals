using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControlleKunde:IControllerKunde
    {
        private IControllerKunde controllerKunde;

        IControllerKunde IControllerKunde.IControllerKunde { set => this.controllerKunde=value; }
    }
}
