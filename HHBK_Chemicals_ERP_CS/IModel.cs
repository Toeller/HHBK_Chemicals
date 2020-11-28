using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        public string Kundenname();
        public string KundenStraße();
        public string KundenHausnummer();
        public int KundePostlietzahl();
        public string KundenOrt();
        public string KundenEmailAdresse();


    }
}
