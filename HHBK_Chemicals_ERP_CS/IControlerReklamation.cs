using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControlerReklamation
    {
        IViewReklamation IView { get; set; }

        IModel IModel { get; set; }
        string Reklamation { get; set; }
        int KundenID { get; set; }
        void ReklamationsgrundSpeichern(string a);

        bool BestelldatenVerifiezieren();

        bool KundendatenVerifizieren();
        string ReklamationErstellen();
        string Kundendatenladen();
        string Bestelldatenladen();
    }
}
