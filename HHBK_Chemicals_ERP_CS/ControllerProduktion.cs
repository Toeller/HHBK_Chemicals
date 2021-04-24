using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerProduktion : IControllerProduktion
    {
        private IModel model;
        private IViewProduktion viewProduktion;
        IViewProduktion IControllerProduktion.IViewProduktion1 { set => this.viewProduktion=value; }
        IModel IControllerProduktion.IModel1 { set => this.model=value; }
    }
}
