using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IView_Rezeptverwalten
    {
        IModel IModel1 { set; }
        IControllerRezeptverwalten IControllerRezeptverwalten1 { set; }
    }
}
