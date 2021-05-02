using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControllerLieferung
    {
        IModel IModel { set; }
        IViewLieferung IViewLieferung { set; }
    }
}
