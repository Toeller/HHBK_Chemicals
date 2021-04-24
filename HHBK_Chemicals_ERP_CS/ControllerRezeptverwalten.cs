using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerRezeptverwalten : IControllerRezeptverwalten
    {
        private IModel model;
        private IViewRezeptverwalten viewRezeptverwalten;
        IViewRezeptverwalten IControllerRezeptverwalten.IViewRezeptverwalten1 { set => this.viewRezeptverwalten=value; }
        IModel IControllerRezeptverwalten.IModel1 { set => this.model=value; }
    }
}
