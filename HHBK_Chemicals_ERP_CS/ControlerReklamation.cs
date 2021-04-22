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
        IViewReklamation iView;
        IModel iModel;

    string IControlerReklamation.Reklamation { get => reklamation; set => reklamation = value; }
        IViewReklamation IControlerReklamation.IView { get => iView; set => iView = value; }
        IModel IControlerReklamation.IModel { get => iModel; set => iModel = value; }

        bool IControlerReklamation.BestelldatenVerifiezieren()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        if (rek1.Bestelldatenladen() == IViewReklamation.DatenAufnehmen(1))
        {
            return x = true;
        }
        else
        {
            IViewReklamation.textboxAusgabe.text = "Bestelldaten ungültig";
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
        if (rek1.Kundendatenladen() == IViewReklamation.DatenAufnehmen(2))
        {
            return y = true;
        }
        else
        {
            IViewReklamation.textBoxAusgabe.text = "Kundendaten ungültig";
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