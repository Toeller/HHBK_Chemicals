using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        IForm1 IView { set; }
        IController1 IController1 { set; }

        Bestellung GetBestellung(int bestellnummer);
        bool SetBestellung(Bestellung bestellung);

        List<int> getKundennummer();
    }
}
