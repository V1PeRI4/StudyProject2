using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа с массивом";

            //Ввод длинны массива
            int massLenght = ArrCreate.EnterMasslenght();

            //создание массива
            int[] myArr = new int[massLenght];

            Menu.MainMenu(ref myArr);

        }

    }
}
