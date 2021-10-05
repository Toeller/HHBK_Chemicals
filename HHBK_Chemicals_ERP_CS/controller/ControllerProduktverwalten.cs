using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerProduktverwalten : IControllerProduktverwalten
    {
        private IModel model;
        private IViewProduktverwalten viewProduktverwalten;
  
        IViewProduktverwalten IControllerProduktverwalten.IViewProduktverwalten1 { set => this.viewProduktverwalten=value; }
        IModel IControllerProduktverwalten.IModel1 { set => this.model=value; }
    }
}
