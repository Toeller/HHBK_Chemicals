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
    public partial class ViewReklamation : Form,IViewReklamation
    {
        private int Kundenummer;
        private int Bestellnummer;
        private int Artikelnummer;
        private string Reklamationsgrund;

        public ViewReklamation()
        {
            InitializeComponent();
        }

        
        public int Bestellnummer1 { get => Bestellnummer; set => Bestellnummer = value; }
        public int Artikelnummer1 { get => Artikelnummer; set => Artikelnummer = value; }
        public string Reklamationsgrund1 { get => Reklamationsgrund; set => Reklamationsgrund = value; }
        public int Kundenummer1 { get => Kundenummer; set => Kundenummer = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            IViewReklamation Reka = new ViewReklamation();
            Reka.DatenAufnehmen(0);
        }

       int IViewReklamation.DatenAufnehmen(int a )
        {

            this.Bestellnummer = Convert.ToInt32(textBoxBestellnummer.Text);
            this.Kundenummer = Convert.ToInt32(textBoxKundennummer.Text);
            this.Artikelnummer = Convert.ToInt32(textBoxArtikelnummer.Text);
            this.Reklamationsgrund = textBoxReklamationsgrund.Text;

            if (a==1)
            {
                return Bestellnummer;
            }
            else if (a==2)
            {
                return Kundenummer;  
            }
            else
            {
                return 0;
            }
        }
    }
}
