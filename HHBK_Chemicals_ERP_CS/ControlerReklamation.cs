using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControlerReklamation : IControlerReklamation
    { 
    private bool x =false;
    private bool y =false;
    private string antwort ="dummi";
    private string reklamationsGrund ="dummi";
        private int bestellnummer;
        private int kundennummer;



        
      private  IViewReklamation iView;
       private IModel iModel;

    string IControlerReklamation.ReklamationsGrund { get => reklamationsGrund; set => reklamationsGrund = value; }
        IViewReklamation IControlerReklamation.IView { get => iView; set => iView = value; }
        IModel IControlerReklamation.IModel { get => iModel; set => iModel = value; }
        int IControlerReklamation.Kundennummer { get => kundennummer; set => kundennummer = value; }
        int IControlerReklamation.Bestellnummer { get => bestellnummer; set => bestellnummer = value; }

        bool IControlerReklamation.BestelldatenVerifiezieren()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        if (rek1.Bestelldatenladen() == /*IView.DatenAufnehmen(1)*/"")
        {
            return x = true;
        }
        else
        {
            /*IView.textboxAusgabe.text = "Bestelldaten ungültig";*/
            return x = false;
        }
    }
    string IControlerReklamation.Bestelldatenladen()
    {
            return ""; // IModel.Bestelldatenladen();
    }



    string IControlerReklamation.Kundendatenladen()
    {
            return ""; // IModel.KundendatenLaden();
    }

    bool IControlerReklamation.KundendatenVerifizieren()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        if (rek1.Kundendatenladen() == /*IView.DatenAufnehmen(2)*/"")
        {
            return y = true;
        }
        else
        {
            //IView.textBoxAusgabe.text = "Kundendaten ungültig";
            return y = false;
        }
    }



    void IControlerReklamation.ReklamationsgrundSpeichern(string a)
    {
        this.reklamationsGrund = a;

    }

    string IControlerReklamation.ReklamationErstellen()
    {
        IControlerReklamation rek1 = new ControlerReklamation();
        rek1.BestelldatenVerifiezieren();
        rek1.KundendatenVerifizieren();

        if (x == true || y == true)
        {
            return rek1.AntwortAI();
        }
        else
        {
            return "";
        }
     }

        string IControlerReklamation.AntwortAI()
        {
            return antwort = "Ihre beschwerde wird bearbeitet, ein Mitarbeiter wird sich mit ihnen in verbindung setzten";
        }

        void IControlerReklamation.Datenspeichern()
        {
            throw new NotImplementedException();
        }

        /*void IControlerReklamation.Datenspeichern()
        {
           this.bestellnummer = iView.Bestellnummer1;
            this.kundennummer = iView.Kundennummer1;
        }
        */
    }
}

