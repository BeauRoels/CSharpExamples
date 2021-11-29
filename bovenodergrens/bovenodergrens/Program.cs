using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bovenodergrens
{
    class Program
    {
        static void Main(string[] args)
        {


            int onder, boven, willekeurig;

            Console.Write("geef een ondergrens in: ");
            onder = int.Parse(Console.ReadLine());

            Console.Write("geef een bovengrens in: ");
            boven = int.Parse(Console.ReadLine());

            //functie aanroepen

            willekeurig = willekeurigGetal(onder, boven);

            //willekeurig getal weergeven

            Console.WriteLine("het getal is " + willekeurig);
            //wachten op enter

            Console.WriteLine();
            Console.WriteLine("druk op enter");
            Console.ReadLine();


        }
        //functie
        private static int willekeurigGetal(int onder, int boven)
        {
            Random rand = new Random();
            int willekeurig;
            willekeurig = rand.Next(onder, boven + 1);
            //geef u var door naar hoofdprogramma
            return willekeurig;
        }
    }
}
