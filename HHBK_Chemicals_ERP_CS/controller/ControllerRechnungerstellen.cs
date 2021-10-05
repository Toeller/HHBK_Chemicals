using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerRechnungerstellen : IControllerRechnungerstellen
    {
        private IModel model;
        private IViewRechnungerstellen viewRechnungerstellen;
        IViewRechnungerstellen IControllerRechnungerstellen.IViewRechnungerstellen1 { set => this.viewRechnungerstellen = value; }
        IModel IControllerRechnungerstellen.IModel1 { set => this.model=value; }
    }
}
