using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IView_Bestellung
    {
        int Anlegen();
        int Louschen();
        int Aondern();

        IModel model1 {set; get;}
        IController_Bestellung controler1 { set; get; } 

    }

}
