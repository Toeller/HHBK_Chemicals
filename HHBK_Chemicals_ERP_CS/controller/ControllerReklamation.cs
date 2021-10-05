using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerReklamation:IControllerReklamation
    {
        private IModel model;
        private IViewReklamation viewReklamation;

        IViewReklamation IControllerReklamation.IViewReklamation1 { set => this.viewReklamation=value; }
        IModel IControllerReklamation.IModel1 { set => this.model=value; }
    }
}
