using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerLagereingang : IControllerLagereingang
    {
        private IControllerLagereingang controllerLagereingang;
        IControllerLagereingang IControllerLagereingang.IControllerLagereingang { set => this.controllerLagereingang = value; }
    }
}
