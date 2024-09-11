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
                areeStr += $"Area {aree.IndexOf(area) + 1}\n{area}";
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
    }
}
