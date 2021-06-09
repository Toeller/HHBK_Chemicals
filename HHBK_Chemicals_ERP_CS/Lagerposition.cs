namespace HHBK_Chemicals_ERP_CS
{
    public class Lagerposition
    {
        private int lagerpositionsnummer;
        private string grundstoffname;
        private int grundstoffmenge;
        private string grundstoffeinheit;

        public int Lagerpositionsnummer { get => lagerpositionsnummer; set => lagerpositionsnummer = value; }
        public string Grundstoffname { get => grundstoffname; set => grundstoffname = value; }
        public int Grundstoffmenge { get => grundstoffmenge; set => grundstoffmenge = value; }
        public string Grundstoffeinheit { get => grundstoffeinheit; set => grundstoffeinheit = value; }
    }
}