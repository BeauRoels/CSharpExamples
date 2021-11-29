using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foutmelding
{
    class Program
    {
        static void Main(string[] args)
        {


            //var declareren
            string getalstring;
            int getal;

            //getal opvragen
            do
            {
                Console.Write("geef een getal in ");
                getalstring = Console.ReadLine();
                //als het een geen int is dan komt er een foutmelding
                if (!int.TryParse(getalstring, out getal))
                {
                    ToonFoutmelding();
                }

            }
            while (!int.TryParse(getalstring, out getal));
            //weergave van getal

            Console.WriteLine("je gaf " + getal + " in");
            //wachten op enter
            Console.WriteLine("druk op enter");
            Console.ReadLine();

        }
        //methode
        private static void ToonFoutmelding()
        {
            //kader tonen
            ConsoleColor vorigekleur = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("\t***************************");
            Console.WriteLine("\t*je moet een getal ingeven*");
            Console.WriteLine("\t***************************");
            Console.WriteLine();
            Console.ForegroundColor = vorigekleur;
        }
    }
}
