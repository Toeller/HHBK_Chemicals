using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    public partial class ViewZahlungseingangPruefen : Form, IViewZahlungseingangPruefen
    {
        public ViewZahlungseingangPruefen()
        {
            InitializeComponent();
        }
        int zahlungseingangsnummer;
        int IViewZahlungseingangPruefen.Zahlungseingansnummer { get => zahlungseingangsnummer; set => zahlungseingangsnummer = value; }

        bool IViewZahlungseingangPruefen.Aendern()
        {
            zahlungseingangsnummer = Convert.ToInt32(textBox1.Text);
            //return IControllerZahlungseingangPruefen.Aendern();
            return true;
        }

        void IViewZahlungseingangPruefen.Anzeigen(int Zahlungseingangsnummer, string VerwendungszweckKdNr, string VerwendungszweckBestNr, string Datum, string NameKontoinhaber, string IBAN, int Kunde_Kundennummer)
        {
            
            textBox1.Text = Zahlungseingangsnummer.ToString();
            textBox2.Text = VerwendungszweckKdNr;
            textBox3.Text = VerwendungszweckBestNr;
            textBox4.Text = Datum;
            textBox5.Text = NameKontoinhaber;
            textBox6.Text = IBAN;
            textBox7.Text = Kunde_Kundennummer.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool IViewZahlungseingangPruefen.Loeschen()
        {
            zahlungseingangsnummer = Convert.ToInt32(textBox1.Text);
            // return IControllerZahlungseingangPruefen.Loeschen();
            return true;
        }

       

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            IViewZahlungseingangPruefen Y = new ViewZahlungseingangPruefen();
            Y.Aendern();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            IViewZahlungseingangPruefen Z = new ViewZahlungseingangPruefen();
            Z.Loeschen();
        }
    }
}
