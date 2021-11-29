using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p187Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fuculteit, getal,boven,onder;
            string getalstring;
            boven = 15;
            onder = 1;
            getal = GetInt_v3("geef getal in ", 1, 15);
            Console.ReadLine();
         
            
            Console.WriteLine( GetInt_v4(getal.ToString() + "!", getal));
            Console.ReadLine();
            
        }

        private static int GetInt_v4(string fuculteit,int getal)
        {
            int  faculteit, teller;
            faculteit = 1;
            for (teller = 1; teller <= getal; teller++)
                faculteit = faculteit * teller;
            return faculteit;
        }

        private static int GetInt_v3(string vraag, int ondergrens=1, int bovengrens=15)
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
                        Toonfoutmelding();
                    }
                }
                while (!int.TryParse(getalstring, out getal));
                if (getal < ondergrens)
                {
                    Console.WriteLine("getal is te klein en moet hoger dan " + ondergrens.ToString() + " zijn");
                }
                if (getal > bovengrens)
                {
                    Console.WriteLine("getal is te groot en moet lager dan " + bovengrens.ToString() + " zijn");
                }
            }
            while (getal < ondergrens || getal > bovengrens);
            return getal;
           
        }

        private static void Toonfoutmelding()
        {
           
        }
    }
}
