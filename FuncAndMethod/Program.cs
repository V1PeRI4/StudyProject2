using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndMethod
{
    internal class Program
    {
        //линия из символов 
        static void PrintLine(string symbol, uint countSymbol)
        {
            for (int i = 0; i < countSymbol; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }


        //найти индекс элемента
        static int IndexOf(int[] array)
        {
            Console.Write("Введите что надо найти: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        //заполнить радоммом массив 
        static int[] GetRandomArray(uint lenght, int minValue, int maxValue)
        {
            int[] myArray = new int[lenght];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(minValue, maxValue);

            return myArray;
        }

        //притить массив
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + "\t");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.Write("Введите количество символов: ");
            uint countSymbol = uint.Parse(Console.ReadLine());

            PrintLine(symbol, countSymbol);


            //////////
            ///

            int [] myArray= GetRandomArray(10, -10, 10);

            PrintArray(myArray); 

            Console.WriteLine(IndexOf(myArray));


            Console.ReadLine();

        }
    }
}
