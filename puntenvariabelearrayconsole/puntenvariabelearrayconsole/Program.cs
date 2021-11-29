using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntenvariabelearrayconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string leerkracht;
            string vak;
            int aantpunt;
            double tot = 0;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


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
            foreach (double print in punt)
            {
                //telt op per keer dat je op enter drukt
                Console.Write(" "+print+" ");




            }

            foreach (double totaal in punt)
            {
                //telt op per keer dat je op enter drukt
                tot += totaal;
             



            }
            
            Console.WriteLine("tot "+tot+"/"+aantpunt*10);
            Console.WriteLine("max " + punt.Max());
            Console.WriteLine("min " + punt.Min());
            Console.WriteLine("gemiddelde (op10)" + punt.Average());
            Console.WriteLine("gemiddelde (op100)"+ (tot/aantpunt)*10);
            Console.ReadLine();

        }
    }
}
