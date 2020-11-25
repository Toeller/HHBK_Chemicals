using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        int Create_Rechnung(string Num);
        int Create_Rechnung();

        string Table_Name { set; }
    }
}
