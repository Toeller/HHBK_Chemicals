using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerRezeptverwalten : IControllerRezeptverwalten
    {
        private IControllerRezeptverwalten controllerRezeptverwalten;
        IControllerRezeptverwalten IControllerRezeptverwalten.IControllerRezeptverwalten { set => this.controllerRezeptverwalten=value; }
    }
}
