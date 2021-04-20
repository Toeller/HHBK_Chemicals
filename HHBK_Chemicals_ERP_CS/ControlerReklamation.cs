using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControlerReklamation : IControlerReklamation
    { 
    private bool x;
    private bool y;
    private string antwort;
    private string reklamation;

    string IControlerReklamation.Reklamation { get => reklamation; set => reklamation = value; }


    bool IControlerReklamation.BestelldatenVerifiezieren()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        if (rek1.Bestelldatenladen() == IViewReklamation.BestelldatenAufnehmen)
        {
            return x = true;
        }
        else
        {
            IViewReklamation.MessageboxAusgabe.text = "Bestelldaten ungültig";
            return x = false;
        }
    }
    string IControlerReklamation.Bestelldatenladen()
    {
        return IModel.Bestelldatenladen();
    }



    string IControlerReklamation.Kundendatenladen()
    {
        return IModel.KundendatenLaden();
    }

    bool IControlerReklamation.KundendatenVerifizieren()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        if (rek1.Kundendatenladen() == IViewReklamation.KundendatenAufnehmen)
        {
            return y = true;
        }
        else
        {
            IViewReklamation.MessageboxAusgabe.text = "Kundendaten ungültig";
            return y = false;
        }
    }



    void IControlerReklamation.ReklamationsgrundSpeichern(string a)
    {
        this.reklamation = a;

    }

    string IControlerReklamation.ReklamationErstellen()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        rek1.BestelldatenVerifiezieren();
        rek1.KundendatenVerifizieren();

        if (x == true || y == true)
        {
            return antwort;
        }
        else
        {
            return "";
        }
     }
    }

}