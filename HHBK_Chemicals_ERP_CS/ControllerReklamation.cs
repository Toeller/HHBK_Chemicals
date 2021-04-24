using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerReklamation:IControllerReklamation
    {
        private IControllerReklamation controllerReklamation;

        IControllerReklamation IControllerReklamation.IControllerReklamation { set => this.controllerReklamation=value; }
    }
}
