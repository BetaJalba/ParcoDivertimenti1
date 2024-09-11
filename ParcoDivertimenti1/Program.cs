using ParcoDivertimenti1;
using System.Runtime.CompilerServices;

namespace ParcoDivertimenti
{
    public class Program
    {
        private static void Main()
        {
            CParcoDivertimenti parco1 = new CParcoDivertimenti("le giostre di bragagnolo", "balneare");
            CArea area1 = new CArea(5, new DateTime(25 / 12), new DateTime(25 / 6));

            string[] robe = { "2 metri" };
            CAttrazione attrazione1 = new CAttrazione("la casa secondo", "casa stregata", new DateTime(26 / 12), robe);
            CAttrazione attrazione2 = new CAttrazione("la casa prima", "casa stregata", new DateTime(26 / 12), robe);

            area1.AddAttrazione(attrazione1);
            area1.AddAttrazione(attrazione2);

            parco1.AddArea(area1);
            Console.WriteLine(parco1.ToString());
        }
    }
}