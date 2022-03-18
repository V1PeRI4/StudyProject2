using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeap
{
    internal class Program
    {

        static int Foo(int a)
        {
            return a = 5;
        }

        static int[] Bar (int[] b)
        {
            b[0] = 5;
            return b; 
        }

        static void Main(string[] args)
        {
            int a = 1;
            
            Foo(a);
            Console.WriteLine("int a без метода в writeLine: " + a);
            //т.к. int это структура, а она хранится в стеке, то пятерка удаляется после выхода из Foo

            Console.WriteLine("int a с методом в WriteLine: " + Foo(a));


            Console.WriteLine(" ||||||||||||||||| "); 
            

            int[] b = new int[1];
            b[0] = 1;

            Bar(b);
            Console.WriteLine("Вывод Массива без метода во врайта: " + b[0]);
            //т.к. массив находится в heap (это класс Array), то он не очищается после выхода из метода

        }
    }
}
