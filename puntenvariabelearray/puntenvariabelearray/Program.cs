using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntenvariabelearray
{
    class Program
    {
        static void Main(string[] args)
        {
            string leerkracht;
            string vak;
            int aantpunt;
            double tot = 0;



            Console.WriteLine("geef naam leerkracht:");
            leerkracht = Console.ReadLine();

            Console.WriteLine("hoeveel punten geef je in:");
            aantpunt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef naam vak:");
            vak = Console.ReadLine();
            int[] punt = new int[aantpunt];
            for (int teller = 0; teller < punt.Length; teller++)
            {
                int toets = teller + 1;

                Console.Write("geef punt toets " + toets + "in(op10): ");
                punt[teller] = Convert.ToInt32(Console.ReadLine());




            }
            foreach (double totaal in punt)
            {
                //telt op per keer dat je op enter drukt
                tot += totaal;
                Console.WriteLine(tot);

            }
            Console.ReadLine();

        }
    }
}
