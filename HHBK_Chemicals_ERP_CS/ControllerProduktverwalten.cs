using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerProduktverwalten : IControllerProduktverwalten
    {
        private IControllerProduktverwalten controllerProduktverwalten;
        IControllerProduktverwalten IControllerProduktverwalten.IControllerProduktverwalten { set => this.controllerProduktverwalten=value; }
    }
}
