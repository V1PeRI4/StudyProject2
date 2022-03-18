using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugeArrays
{
    // ТРЁХМЕРНЫЕ МАССИВЫ | МНОГОМЕРНЫЕ МАССИВЫ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray  = new int[3 ,3, 3];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page: " + (i+ 1 ));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + "\t"); 
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
