using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43less_num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int massLenght = int.Parse(Console.ReadLine());
            int[] myArr = new int[massLenght];

            EnterMass(ref myArr);

            Line();

            PrintMass(myArr);

            Line();

        }

        static void Line()
        {
            Console.WriteLine("-----------------");
        }

        static void EnterMass(ref int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"Введите элемент под номером [{i}] : ");
                Arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintMass(int[] Arr)
        {
            Console.WriteLine("Введенный массив: ");
            for (int i = 0; i < Arr.Length; i++)
                Console.WriteLine($"myArr[{i}] = {Arr[i]}\t");
        }
    }
}
