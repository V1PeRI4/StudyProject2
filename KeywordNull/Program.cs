using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordNull
{
    internal class Program
    {

        static void Foo()
        {
            int[] b = new int[10];
        }

        static void Main(string[] args)
        {
            Foo();

            //через дебаг после выхода из метода Foo теряется ссылка на массив
            //но данные остаются, после чего они удаляются сборщиком мусора
            //Console.WriteLine(b[0]);
            // Имя "b" не существует в текущем контексте.KeywordNull


            //////////////////////////////////////
            

            // null- обьединения
            string str = null; 
            Console.WriteLine(str ?? "Нет данных");
            //Если переменная null, то сработает два вопроса и вывод сообщения

            Console.WriteLine("-------------------------");

            string str2 = "test";
            
            string result = str2 ?? string.Empty;

            Console.WriteLine(str2);

            Console.WriteLine("Кол-во символов в строке: " + result.Length);

            
        }
    }
}
