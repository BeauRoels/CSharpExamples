using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //aantal items in array
            int aantalitems;
            //de ingegeven uitkomst door de gebruiker
            int ingaveuitkomst;
            //tussenvariabele om te kijken of ingave een getal is
            string ingaveuitkomststring;
            


            int oef;
            aantalitems= 5;
            //random getal aanmaken
            Random getal = new Random();
           
         
            //array aanmaken
            int[] poeper = new int[aantalitems];
            
            

            //array voorwaarden opstellen
            for (int teller = 0; teller < poeper.Length; teller++)
            {
                //getallen in array stoppen
                poeper[teller] = getal.Next(1, 9);
                Console.WriteLine(poeper[teller]);
                
            }
            //som van getallen in functie zetten
            oef=somgetallen(poeper[0], poeper[1], poeper[2], poeper[3], poeper[4]);
           
            do
            {
                Console.WriteLine("geef de som van de opgegeven getallen in");
                ingaveuitkomststring = Console.ReadLine();
                //als de ingave geen getal is komt er een foutmelding
                
                if (!int.TryParse(ingaveuitkomststring, out ingaveuitkomst))
                {
                    //methode oproepen
                    foutmelding();
                }
            }
            //zolang het antwoord fout is blijft de vraag herhalen
            while (ingaveuitkomst != oef);
            //wanneer het antwoord juist is komt er een melding
            if(ingaveuitkomst==oef)
            {
                //methode oproepen
                juist();
            }
            Console.WriteLine();

            //2Darray
            //breedte van 2D array
            double[] breedte = new double[1];
            //hoogte van 2D array
            string[] hoogte = new string[5] { "leeftijd ", "getal ", " creditcardnumer", "pincode ", "banksaldo " };
            int[,] DoublePennetration = new int[5, 1];
            for (int x = 0; x < DoublePennetration.GetLength(0); x++)
            {
                Console.WriteLine(hoogte[x]);
                for (int y = 0; y < DoublePennetration.GetLength(1); y++)
                {
                    DoublePennetration[x, y] = int.Parse(Console.ReadLine());
                }
            }
            for(int z =0; z<DoublePennetration.GetLength(0);z++)
             {
                //wergeven van gegevens per "hoogte[z]"
                Console.WriteLine(hoogte[z]+DoublePennetration[z,0]);
             }

            Console.WriteLine();
            Console.ReadLine();
        }
        //som van getallen berekenen
        private static int somgetallen(int num01,int num02,int num03,int num04, int num05)
        {
            //som van getallen terugzetten
            return num01+num02+num03+num04+num05;
        }

        //methode verklaren
        private static void juist()
        {
            // er wordt een var gemaakt om de standaardkleur terug te zetten
            ConsoleColor vorige = Console.ForegroundColor;
            //er wordt een nieuwe kleur ingesteld
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine("*GOED ANTWOORD!*");
            Console.WriteLine("****************");
            Console.WriteLine();
            //kleur wordt teruggezet naar vorige waarde
            Console.ForegroundColor = vorige;
        }

        private static void foutmelding()
        {
            ConsoleColor vorige = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine("**!FOUTMELDING!**");
            Console.WriteLine("**|foute input|**");
            Console.WriteLine("*****************");
            Console.WriteLine();
            Console.ForegroundColor=vorige;



        }
    }
}
