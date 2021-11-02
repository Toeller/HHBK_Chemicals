using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    public interface IView
    {
        IModel IModel1 { set; }
        IController IController1 { set; }

        void Show(List<Produkt> produktliste);
        void Show(List<Kunde> kundenListe);

    }
}
