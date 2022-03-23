using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43lesson
{
    internal class Separators
    {
        public static void Line() 
        {
            Console.WriteLine("-----------------");
        }


        public static void PressEnterToContinue()
        {
            Console.WriteLine();
            Line();
            Console.WriteLine("Нажмите Enter для выхода в главное меню");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
