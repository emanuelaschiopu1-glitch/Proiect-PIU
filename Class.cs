namespace ExempluClase
{
    public class Eveniment
    {
        // data membră privată
        private string locatie;

        // proprietăți auto-implemented
        public string NumeEveniment { get; set; }
        public string TipEveniment { get; set; }
        public string Organizator { get; set; }
        public DateTime DataEveniment { get; set; }
        public int NrInvitati { get; set; }
        public double Buget { get; set; }

        // constructor fără parametri
        public Eveniment()
        {
            NumeEveniment = string.Empty;
            TipEveniment = string.Empty;
            Organizator = string.Empty;
            locatie = string.Empty;
            NrInvitati = 0;
            Buget = 0;
        }

        // constructor cu parametri
        public Eveniment(string nume, string tip, string organizator, DateTime data, string loc, int invitati, double buget)
        {
            NumeEveniment = nume;
            TipEveniment = tip;
            Organizator = organizator;
            DataEveniment = data;
            locatie = loc;
            NrInvitati = invitati;
            Buget = buget;
        }

        // metode set/get pentru locatie
        public void SetLocatie(string loc)
        {
            locatie = loc;
        }

        public string GetLocatie()
        {
            return locatie;
        }

        // proprietate computed
        public bool EsteEvenimentMare
        {
            get
            {
                return NrInvitati >= 100;
            }
        }

        // metoda care returneaza informatiile
        public string Info()
        {
            if (string.IsNullOrEmpty(NumeEveniment))
            {
                return "Eveniment nesetat";
            }

            return $"Eveniment: {NumeEveniment}, Tip: {TipEveniment}, Organizator: {Organizator}, Data: {DataEveniment.ToShortDateString()}, Locatie: {locatie}, Invitati: {NrInvitati}, Buget: {Buget}";
        }
    }
}