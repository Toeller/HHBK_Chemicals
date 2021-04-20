using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Controller1 : IController1
    {
        private IModel imodel;
        private IForm1 iform1;
        IModel IController1.IModel { set => this.imodel=value; }
        IForm1 IController1.IForm1 { set => this.iform1=value; }

        List<int> IController1.getKundennummern()
        {
            return imodel.getKundennummer();
        }
    }
}
