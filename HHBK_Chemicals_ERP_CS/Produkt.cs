namespace HHBK_Chemicals_ERP_CS
{
    public class Produkt
    {
        private int artikelnummer;
        private string artikelname;
        private int verkaufseinheit;
        private string einheit;
        private double preisVk;

        public int Artikelnummer { get => artikelnummer; set => artikelnummer = value; }
        public string Artikelname { get => artikelname; set => artikelname = value; }
        public int Verkaufseinheit { get => verkaufseinheit; set => verkaufseinheit = value; }
        public string Einheit { get => einheit; set => einheit = value; }
        public double PreisVk { get => preisVk; set => preisVk = value; }
    }
}