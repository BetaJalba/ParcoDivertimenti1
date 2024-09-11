using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcoDivertimenti1
{
    public class CAttrazione
    {
        string nome { get; set; }
        string tipo { get; set; }
        //tipologia attrazione: montagna russa, giostra, casa stregata, ...
        DateTime dataInaugurazione { get; set; }
        string[] elencoRestrizioni { get; set; }
        //restrizioni: eta, altezza, peso

        public CAttrazione() 
        {
            nome = "default";
            tipo = "nessuno";
            dataInaugurazione = DateTime.Now;
            elencoRestrizioni = new string[0]; //array vuoto
        }

        public CAttrazione(string nome, string tipo, DateTime dataInaugurazione, string[] elencoRestrizioni) 
        {
            this.nome = nome;
            this.tipo = tipo;
            this.dataInaugurazione = dataInaugurazione;
            this.elencoRestrizioni = elencoRestrizioni;
        }

        public override string ToString()
        {
            string restrizioni = String.Join(" ", elencoRestrizioni.Select(restrizione => restrizione.ToString()));
            if (restrizioni.Length < 1)
                restrizioni = "nessuna";
            return $"Nome attrazione: {nome}\nTipo attrazione: {tipo}\nRestrizioni: {restrizioni}";
        }
    }
}
