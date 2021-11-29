using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P183Oef9
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal ;
            string getalstring;


            Console.Write("geef een getal in: ");
            getal = Getint_v3("geef getal in: ");
            Console.ReadLine();

            Console.WriteLine("het getal is " + getal);
            //wachten op enter

            Console.WriteLine();
            Console.WriteLine("druk op enter");
            Console.ReadLine();







        }

        private static int Getint_v3(string vraag, int ondergrens =0, int bovengrens =10)
        {
            string getalstring;
            int getal;
            do
            {
                do
                {
                    Console.Write(vraag);
                    getalstring = Console.ReadLine();
                    if (!int.TryParse(getalstring, out getal))
                    {
                        toonfoutmelding();
                    }
                }
                while (!int.TryParse(getalstring, out getal));
                if (getal < ondergrens)
                {
                    Console.WriteLine("getal is te klein. Getal moet groter zijn of gelijk aan " + ondergrens.ToString() + " zijn");

                }
                if (getal > bovengrens)
                {
                    Console.WriteLine("getal is te groot. Getal moet kleiner zijn of gelijk aan " + ondergrens.ToString() + " zijn");
                }

            }
            while (getal < ondergrens || getal > bovengrens);
            return getal;
        }

        private static void toonfoutmelding()
        {
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
