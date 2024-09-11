using ParcoDivertimenti1;
using System.Runtime.CompilerServices;

namespace ParcoDivertimenti
{
    public class Program
    {
        private static void Main()
        {
            CParcoDivertimenti parco1 = new CParcoDivertimenti("le giostre di bragagnolo", "balneare");
            CArea area1 = new CArea(5, new DateTime(2020,1,20), new DateTime(2020,5,20));

            string[] robe = { "2 metri" };
            CAttrazione attrazione1 = new CAttrazione("la casa secondo", "casa stregata", new DateTime(26 / 12), robe);
            CAttrazione attrazione2 = new CAttrazione("la casa prima", "casa stregata", new DateTime(26 / 12), robe);

            area1.AddAttrazione(attrazione1);
            area1.AddAttrazione(attrazione2);

            parco1.AddArea(area1);

            CArea area2 = new CArea(5, new DateTime(2020, 1, 20), new DateTime(2020, 5, 20));

            string[] requisiti = { "" };
            CAttrazione attrazione3 = new CAttrazione("la casa secondo", "casa stregata", new DateTime(26 / 12), robe);
            CAttrazione attrazione4 = new CAttrazione("montagna del terrore", "montagne russe", new DateTime(26 / 12), requisiti);

            area2.AddAttrazione(attrazione3);
            area2.AddAttrazione(attrazione4);

            parco1.AddArea(area2);
            Console.WriteLine(parco1.ToString());
            Console.WriteLine(parco1.ElencoAttrazioni(4));
        }
    }
}