using System.Collections.Generic;
using System.Linq;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareEvenimenteMemorie
    {
        private List<Eveniment> evenimente;

        public AdministrareEvenimenteMemorie()
        {
            evenimente = new List<Eveniment>();
        }

        public void AddEveniment(Eveniment ev)
        {
            ev.IdEveniment = GetNextId();
            evenimente.Add(ev);
        }

        public List<Eveniment> GetEvenimente()
        {
            return evenimente;
        }

        public Eveniment GetEveniment(string nume)
        {
            return evenimente.FirstOrDefault(e => e.NumeEveniment.Equals(nume, System.StringComparison.OrdinalIgnoreCase));
        }

        public List<Eveniment> GetEvenimenteTip(string tip)
        {
            return evenimente.Where(e => e.TipEveniment.Equals(tip, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private int GetNextId()
        {
            return evenimente.Count == 0 ? 1 : evenimente.Last().IdEveniment + 1;
        }
    }
}