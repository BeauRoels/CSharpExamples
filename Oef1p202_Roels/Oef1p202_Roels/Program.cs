using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1p202_Roels
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] woord = new string[6];
            for (int teller = 1;  teller < woord.Length; teller++)
            {
             
                Console.WriteLine("geef woord"+teller + ":");
                
                woord[teller] = Console.ReadLine();



               
            }
            foreach(string weergeven in woord)
            {
                Console.WriteLine(weergeven);
            }
            Console.ReadLine();
        }
    }
}
