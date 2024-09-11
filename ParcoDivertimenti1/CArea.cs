using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcoDivertimenti1
{
    public class CArea
    {
        public List<CAttrazione> AttrazioniInCorso { get; private set; }
        float visitatoriAtOra { get; set; }
        //la media dei visitatori può essere decimale
        public DateTime DataApertura { get; private set; }
        public DateTime DataChiusura { get; private set; }

        public CArea()
        {
            AttrazioniInCorso = new List<CAttrazione>();
            visitatoriAtOra = 0;
            DataApertura = DateTime.Now;
            DataChiusura = DateTime.MaxValue; //non chiude
        }

        public CArea(float visitatoriAtOra, DateTime DataApertura, DateTime DataChiusura) 
        {
            AttrazioniInCorso = new List<CAttrazione>();
            this.visitatoriAtOra = visitatoriAtOra;
            this.DataApertura = DataApertura;
            this.DataChiusura = DataChiusura;
        }

        public override string ToString()
        {
            string attrazioni = String.Join("\n\n", AttrazioniInCorso.Select(attrazione => attrazione.ToString()));
            if (attrazioni.Length < 1)
                attrazioni = "nessuna";
            return $"Visitatori all'ora: {visitatoriAtOra}\nData apertura: {DataApertura}\nData chiusura: {DataChiusura}\n\n\tAttrazioni:\n{attrazioni}";
        }

        public void AddAttrazione(CAttrazione attrazione) 
        {
            AttrazioniInCorso.Add(attrazione);
        }

        public void RemoveAttrazione(CAttrazione attrazione)
        {
            while (AttrazioniInCorso.IndexOf(attrazione) != -1) //per non usare .Contains()
                AttrazioniInCorso.Remove(attrazione);
        }
    }
}
