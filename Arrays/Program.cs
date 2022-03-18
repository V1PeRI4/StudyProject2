using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        //двумерные массивы
        static void Main(string[] args)
        {
            int [,] myArray = new int [3, 5];

            Random random = new Random();

            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    //myArray[i, j] = random.Next(100);
                    Console.Write("Y: " + i + " X: "+ j + " Num: ");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
                
            }


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                    
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nСкольки ранговый массив: " + myArray.Rank);


            
        }
    }
}
