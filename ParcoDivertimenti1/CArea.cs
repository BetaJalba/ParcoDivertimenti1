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
        DateTime dataApertura { get; set; }
        DateTime dataChiusura { get; set; }

        public CArea()
        {
            AttrazioniInCorso = new List<CAttrazione>();
            visitatoriAtOra = 0;
            dataApertura = DateTime.Now;
            dataChiusura = DateTime.MaxValue; //non chiude
        }

        public CArea(float visitatoriAtOra, DateTime dataApertura, DateTime dataChiusura) 
        {
            AttrazioniInCorso = new List<CAttrazione>();
            this.visitatoriAtOra = visitatoriAtOra;
            this.dataApertura = dataApertura;
            this.dataChiusura = dataChiusura;
        }

        public override string ToString()
        {
            string attrazioni = String.Join("", AttrazioniInCorso.Select(attrazione => attrazione.ToString()));
            if (attrazioni.Length < 1)
                attrazioni = "nessuna";
            return $"Visitatori all'ora: {visitatoriAtOra}\nData apertura: {dataApertura}\nData chiusura: {dataChiusura}\nAttrazioni:\n{attrazioni}";
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
