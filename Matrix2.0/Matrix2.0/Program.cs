using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
            decimal answer ;

            Random rand = new Random();
            int getal = rand.Next(0, 2);

            Console.WriteLine("type 1 blue pill and 0 for red pill");
            Console.WriteLine("Do you wish to enter the MATRIX: ");
            answer = Convert.ToDecimal(Console.ReadLine());
            if (answer == 1)
            {
                while(true)
                {

                }
            }
            
        }
    }
}
