using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerLagereingang:IControllerLagereingang
    {
        private IModel model;
        private IViewLagereingang viewLagereingang;
        IViewLagereingang IControllerLagereingang.IViewLagereingang1 { set => this.viewLagereingang = value; }
        IModel IControllerLagereingang.IModel1 { set => this.model = value; }
    }
}
