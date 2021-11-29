using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ReadLine();

            int getal1, getal2;
            int oef = 1;
            int juist;
           int uitkomst;

            Random getalgenerator = new Random();
            getal1 = getalgenerator.Next(1, 11);
            getal2 = getalgenerator.Next(1, 11);
            juist = getal1 + getal2;
            do
            {




                Console.WriteLine("oef: " + oef + ") " + getal1 + " + " + getal2 + " = ");
                uitkomst = Convert.ToInt32(Console.ReadLine());
                oef++;




            } while (uitkomst!=juist);
     

            Console.ReadLine();
        }
    }
}
