using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerBestellung : IController_Bestellung
    {
        private IModel model;
        private IView_Bestellung view_Bestellung;

        IModel IController_Bestellung.Model { set => model = value; }
        IView_Bestellung IController_Bestellung.View_Bestellung { set => view_Bestellung = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bestellung"></param>
        /// <param name="newBestellung"></param>
        /// <returns>Wenn das Program fählerfrei galeufen ist gitp eine 0 zürück.</returns>
        int IController_Bestellung.Andern(Bestellung bestellung, Bestellung newBestellung)
        {
            return -1;
            //model.GetBestellung(Bestellung bestellung) 
            //model.SetBestellung(Bestellung bestellung)
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bestellung"></param>
        /// <param name="kunde"></param>
        /// <returns>Return 2 wenn das Kunde nicht vorhanden ist. Return 0 wenn fehlerfrei gelaufen ist.</returns>
        int IController_Bestellung.Anlegen(Bestellung bestellung, Kunde kunde)
        {
            return -1;
        }

        /// <summary>
        /// Speichert die Bestellung wenn die Bestellung noch nicht exist.
        /// </summary>
        /// <param name="bestellposition"> alle bestellpositionen die geschspeichert werden</param>
        /// <returns>Returns -1 wenn eine von die parameters nicht gültig ist. Returns 0 wenn die bestellungSpeichern erforgreich war</returns>
        int IController_Bestellung.bestellungSpeichern(List<Bestellposition> bestellposition)
        {

            try
            {
                if (bestellposition.Count > 0)
                {
                    return 0;
                    //model1.SetBestellung(Bestellung bestellung);
                }
                else
                {
                    throw new BestellungIstLehr();
                }
            }
            catch (BestellungIstLehr bil)
            {
                return bil.Nachricht();
            }
        }
        /// <summary>
        /// Löschd die bestellpositionen wenn vorhanden ist.
        /// </summary>
        /// <param name="bestellpositionen">Alle bestellpositionen was kelöschd wird.</param>
        /// <returns>Returns 0 wenn das Code fählerfrei Gelaufen ist. Returns -1 wenn bestellung ist lehr. Returns 2 wenn In Datenbank Keine Vorhandene Bestellpositions Des Kundens ist.</returns>
        int IController_Bestellung.Loeschen(List<Bestellposition> bestellpositionen)
        {
            try
            {
                List<int> dbkundennummers = new List<int>();
                List<Bestellposition> dbbestellpositions = new List<Bestellposition>();
                int i = 0;
                dbkundennummers = model.getKundennummer();

                for (i = 0; i < bestellpositionen.Count; i++)
                {
                    if (dbkundennummers.Contains(bestellpositionen[i].Kunde_Kundennummer)) break;
                }
                if (i >= bestellpositionen.Count)
                {
                    throw new KunndeIstNichtVorhandenInDatabase();
                }
                dbbestellpositions = null;/*model.Getbestellpositionen(bestellpositionen[i].Kunde_Kundennummer);*/
                if (bestellpositionen.Count == 0)
                {
                    throw new InDatenbankKeineVorhandeneBestellpositionsDesKundens();
                }
                return /*model.LoschenBestellung(bestellpositionen);*/ 1;
            }
            catch (KunndeIstNichtVorhandenInDatabase kinvid)
            {
                return kinvid.Nachricht();
            }
            catch (InDatenbankKeineVorhandeneBestellpositionsDesKundens ex)
            {
                return ex.Nachricht();
            }
        }

        
        
    }
    
    
    [Serializable]
    internal class KunndeIstNichtVorhandenInDatabase : Exception
    {
        public int Nachricht()
        {
            return 2;
        }
    }

    [Serializable]
    internal class BestellungIstLehr : Exception
    {
        public int Nachricht()
        {
            return -1;
        }
    }

    [Serializable]
    internal class InDatenbankKeineVorhandeneBestellpositionsDesKundens : Exception
    {
        public int Nachricht()
        {
            return 3;
        }
    }
}