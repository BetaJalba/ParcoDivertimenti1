using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcoDivertimenti1
{
    public class CParcoDivertimenti
    {
        string nome { get; set; }
        string localita { get; set; }
        List<CArea> aree { get; set; }

        public CParcoDivertimenti(string nome, string localita)
        {
            this.nome = nome;
            this.localita = localita;
            aree = new List<CArea>();
        }

        public override string ToString()
        {
            string areeStr = string.Empty;
            foreach (CArea area in aree) 
            {
                //prende l'indice dell'area e va a capo e intabula
                areeStr += $"\nArea {aree.IndexOf(area) + 1}\n{area}\n";
            }
            return $"Parco divertimenti {nome}\n{areeStr}";
        }

        public void AddArea(CArea area)
        {
            aree.Add(area);
        }

        public void RemoveArea(CArea area)
        {
            while (aree.IndexOf(area) != -1) //per non usare .Contains()
                aree.Remove(area);
        }

        public string ElencoAttrazioni(int mese)
        {
            if (mese > 12 || mese < 0)
                throw new Exception("Mese non valido!");

            string r = $"Elenco attrazioni aperte nel mese {mese}:\n";
            //controlla il mese corrente di tutte le aree e seleziona quelle che sono aperte nel mese dato in input
            foreach (CArea area in aree)
            {
                if (mese >= area.DataApertura.Month && area.DataApertura.Day >= area.DataApertura.Day && mese <= area.DataChiusura.Month && mese <= area.DataChiusura.Day)
                    r += $"{area}\n";       
            }
            return r;
        }
    }
}
