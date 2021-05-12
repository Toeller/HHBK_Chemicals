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
    public partial class UserControlProduktVerwalten : UserControl
    {
        private List<Produkt> produktliste=null;
        private Produkt produkt = new Produkt();

        internal List<Produkt> Produktliste {get => produktliste; set =>produktliste = value;}
        internal Produkt Produkt { get => produkt; set => produkt = value; }

        public event EventHandler UCProduktVerwaltenAendern;
        public event EventHandler UCProduktVerwaltenLoeschen;

        protected virtual void OnUCProduktVerwaltenAendern(object sender, EventArgs e)
        {
            EventHandler handler = UCProduktVerwaltenAendern;
            handler?.Invoke(this, e);
        }

        protected virtual void OnUCProduktVerwaltenLoeschen(object sender, EventArgs e)
        {
            EventHandler handler = UCProduktVerwaltenLoeschen;
            handler?.Invoke(this, e);
        }

        public UserControlProduktVerwalten()
        {
            InitializeComponent();
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            comboBoxArtikelname.Items.Clear();
            comboBoxArtikelnummer.Items.Clear();
            textBoxVerkaufseinheit.Text = "";
            textBoxEinheit.Text = "";
            textBoxPreisVK.Text = "";
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            Produkt.Artikelnummer = Convert.ToInt32(comboBoxArtikelnummer.SelectedItem.ToString());
            Produkt.Artikelname= comboBoxArtikelname.SelectedItem.ToString();
            Produkt.PreisVK= Convert.ToDouble(textBoxPreisVK.Text);
            Produkt.Verkaufseinheit = Convert.ToInt32(textBoxVerkaufseinheit.Text);
            Produkt.Einheit = textBoxEinheit.Text;
            Produkt.ChemischeBezeichnung = textBoxChemischeBezeichnung.Text;

            OnUCProduktVerwaltenAendern(this, e);

        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            Produkt.Artikelnummer = Convert.ToInt32(comboBoxArtikelnummer.SelectedItem.ToString());
            Produkt.Artikelname = comboBoxArtikelname.SelectedItem.ToString();
            Produkt.PreisVK = Convert.ToDouble(textBoxPreisVK.Text);
            Produkt.Verkaufseinheit = Convert.ToInt32(textBoxVerkaufseinheit.Text);
            Produkt.Einheit = textBoxEinheit.Text;
            Produkt.ChemischeBezeichnung = textBoxChemischeBezeichnung.Text;

            OnUCProduktVerwaltenLoeschen(this, e);
        }

        private void UserControlProduktVerwalten_VisibleChanged(object sender, EventArgs e)
        {

            if (produktliste != null)
            {
                comboBoxArtikelnummer.Items.Clear();
               
            
                foreach (Produkt p in produktliste)
                {
                    comboBoxArtikelnummer.Items.Add(p.Artikelnummer.ToString());
                    comboBoxArtikelname.Items.Add(p.Artikelname.ToString());
                }
            }
        }

        private void comboBoxArtikelnummer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArtikelname.SelectedIndex=comboBoxArtikelnummer.SelectedIndex;
            textBoxVerkaufseinheit.Text = produktliste[Convert.ToInt32(comboBoxArtikelnummer.SelectedIndex)].Verkaufseinheit.ToString();
            textBoxPreisVK.Text = produktliste[Convert.ToInt32(comboBoxArtikelnummer.SelectedIndex)].PreisVK.ToString();
            textBoxEinheit.Text= produktliste[Convert.ToInt32(comboBoxArtikelnummer.SelectedIndex)].Einheit.ToString();
            textBoxChemischeBezeichnung.Text= produktliste[Convert.ToInt32(comboBoxArtikelnummer.SelectedIndex)].ChemischeBezeichnung.ToString();
        }

        private void comboBoxArtikelname_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArtikelnummer.SelectedIndex = comboBoxArtikelname.SelectedIndex;
            textBoxVerkaufseinheit.Text = produktliste[Convert.ToInt32(comboBoxArtikelname.SelectedIndex)].Verkaufseinheit.ToString();
            textBoxPreisVK.Text = produktliste[Convert.ToInt32(comboBoxArtikelname.SelectedIndex)].PreisVK.ToString();
            textBoxEinheit.Text = produktliste[Convert.ToInt32(comboBoxArtikelname.SelectedIndex)].Einheit.ToString();
            textBoxChemischeBezeichnung.Text = produktliste[Convert.ToInt32(comboBoxArtikelname.SelectedIndex)].ChemischeBezeichnung.ToString();

        }
    }
}
