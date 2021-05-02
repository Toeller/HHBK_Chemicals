using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IController1
    {
        IModel IModel { set; }
        IForm1 IForm1 { set; }
        List<int> getKundennummern();
    }
}
