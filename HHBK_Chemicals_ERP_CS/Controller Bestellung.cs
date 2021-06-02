using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        /// <returns>Wenn das Program fehlerfrei gelaufen ist, wird eine 0 zurück gegeben.</returns>
        int IController_Bestellung.Andern(Bestellung bestellung, Bestellung newBestellung)
        {

            try
            {
                Bestellung bestellungsRueckgabe=model.GetBestellung(bestellung.Bestellungsnummer);
                model.SetBestellung(newBestellung);
                return 0;
            }
            catch
            {
                return -1;
            }
            finally
            {

            }
            

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
        /// <summary>
        /// Speichert die akktuelles Class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Gegebene classe</param>
        /// <param name="fileName">File Name</param>
        /// <returns></returns>
        string IController_Bestellung.SpeicherAktuellesStatus<T>(T obj, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;

            string message = "successful";
            if (obj == null) return "Given object is null";
            try
            {
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, obj);
                stream.Close();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }
        /// <summary>
        /// Lade die Gegebene Class zuruck
        /// </summary>
        /// <typeparam name="T">Classe mit dem CurrentSatus</typeparam>
        /// <param name="fileName">File Name</param>
        /// <returns></returns>
        T IController_Bestellung.Ladenaktuellestatus<T>(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;
            T objectOut = default(T);
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                objectOut = (T)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception)
            {
                //Error
            }
            return objectOut;
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
    //[Serializable]
    //internal class Data()
    //{

    //}
}