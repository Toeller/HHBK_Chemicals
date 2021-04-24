using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerRechnungerstellen : IControllerRechnungerstellen
    {
        private IControllerRechnungerstellen controllerRechnungerstellen;
        IControllerRechnungerstellen IControllerRechnungerstellen.IControllerRechnungerstellen { set => this.controllerRechnungerstellen = value; }
    }
}
