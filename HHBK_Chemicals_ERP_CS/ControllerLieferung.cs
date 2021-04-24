using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerLieferung:IControllerLieferung
    {
        private IControllerLieferung controllerLieferung;

        IControllerLieferung IControllerLieferung.IControllerLieferung { set => this.controllerLieferung=value; }
    }
}
