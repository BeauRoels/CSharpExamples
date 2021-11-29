using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2DArray_Roels
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            
            


            Console.WriteLine("geef je naam in:");
            naam = Console.ReadLine();
            double[] gemiddelde = new double[5];
            string[] vakken = new string[5] { "ned", "frans", "eng", "prog", "webd" };
            int[,] punt = new int[5,5];


            for (int x = 0; x < punt.GetLength(0); x++)
            {
                Console.WriteLine(vakken[x]);

                for (int y=0;y<punt.GetLength(1);y++)
                {

                    punt[x, y] = int.Parse(Console.ReadLine());
                   


                       
                }

               

              


            }
            for(int z =0; z<punt.GetLength(0);z++)
            {
                gemiddelde[z] = (punt[z, 0] + punt[z, 1] +  punt[z, 2] +punt[z, 3] +  punt[z, 4])/5;
                Console.WriteLine(vakken[z]+":"+punt[z,0]+","+ punt[z, 1] + "," + punt[z, 2] + "," + punt[z, 3] + "," + punt[z, 4]+" gemiddelde is:"+gemiddelde[z]);

            }
            Console.ReadLine();
        }
    }
}
