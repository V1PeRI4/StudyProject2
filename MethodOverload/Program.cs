using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Program
    {   
        /// <summary>
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum (int a, int b)
        {
            return a + b;
        }

        static int Sum (int a, int b, int c)
        {
            return (a + b) + c;
        }

        static double Sum (double a, double b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 5));
            Console.WriteLine(Sum(5, 5, 5));
        }
    }
}
