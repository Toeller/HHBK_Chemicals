using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS.model
{
    interface IKundenliste
    {
        List<Kunde> Kunden { get; }

        void alter(Kunde kunde);
        void delete(Kunde kunde);

        void save(Kunde kunde);

        Kunde getKunde(int kundennummer);


    }
}
