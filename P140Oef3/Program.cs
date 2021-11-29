using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P140Oef2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();

            // veriabelen
            Random Getalgenerator = new Random();

            int getal1, getal2,uitkomst, juist;
            int oef = 1;
            int kansen = 0;
            int pogingen = 0;
            
            

            getal1 = Getalgenerator.Next(1, 11);
            getal2 = Getalgenerator.Next(1, 11);
            juist = getal1 + getal2;




         

            do
            {


                Console.WriteLine("oefening " + oef + " opgave: " + getal1 + " + " + getal2 + " =");
                uitkomst = Convert.ToInt32(Console.ReadLine());

                while (uitkomst == juist)
                {
                    oef++;
                    Random Getalgenerator2 = new Random();
                    getal1 = Getalgenerator2.Next(1, 11);
                    getal2 = Getalgenerator2.Next(1, 11);
                    Console.WriteLine("oefening " + oef + " opgave: " + getal1 + " + " + getal2 + " =");
                    uitkomst = Convert.ToInt32(Console.ReadLine());
                    pogingen++;
                    

                }

                if (uitkomst != juist)
                    {
                    kansen++;
                    Console.WriteLine("kansen: " + kansen);
                    pogingen++;

                }



            }


            while (uitkomst != juist);

            Console.ReadLine();







        }
    }
}
