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

            //Ввод длинны массива
            int massLenght = ArrCreate.EnterMasslenght();
            //int massLenght= 0; --------------------------------доделай

            //создание массива
            int[] myArr = new int[massLenght];

            Menu.MainMenu(ref myArr);

        }






        /// <summary>
        /// 4. Изменение длинны массива
        /// </summary
        static void Resize(ref int[] myArr)
        {
            Console.WriteLine($"Изначальная длина: {myArr.Length}");
            int newSize;
            while (true)
            {
                try
                {
                    Console.Write("Введите новую длину массива: ");
                    newSize = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
                }
            }

            int[] newArr = new int[newSize];

            for (int i = 0; i < newSize && i < myArr.Length; i++)
                newArr[i] = myArr[i];

            if (newSize > myArr.Length)
            {
                Console.WriteLine("\nВведите новые элементы:");
            }

            for (int i = myArr.Length; i < newSize; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Элемент mass[{i}]: ");
                        newArr[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
                    }
                }
            }
            myArr = newArr;
        }

        
        /// <summary>
        /// 5. Добавление элемента
        /// </summary>
        static void Insert(ref int[] myArr)
        {
            int numOfNewEl;
            while (true)
            {
                try
                {
                    Console.Write("Введите номер в массиве, куда хотите вставить новый элемент: ");
                    numOfNewEl = int.Parse(Console.ReadLine());
                    if (numOfNewEl < 0 || numOfNewEl > myArr.Length)
                    {
                        Console.WriteLine("!!!! Error: Номер элемента вне границ массива и будет вставлен в начало");
                        numOfNewEl = 0;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
                }
            }

            int[] newArr = new int[myArr.Length + 1];

            try
            {
                Console.Write($"Введите новый элемент [{numOfNewEl}]: ");
                int newEl = int.Parse(Console.ReadLine());
                newArr[numOfNewEl] = newEl;
                Console.WriteLine("Массив увеличился на 1 элемент" +
                    $"\nmyArr[{numOfNewEl}] = {newEl}");
            }
            catch
            {
                Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
            }

            for (int i = 0; i < numOfNewEl; i++)
            {
                newArr[i] = myArr[i];
            }

            for (int i = numOfNewEl + 1; i < newArr.Length; i++)
            {
                newArr[i] = myArr[i - 1];
            }
            myArr = newArr;
        }


        /// <summary>
        /// 6. Удаление элемента
        /// </summary>
        static void RemoveEl(ref int[] myArr)
        {
            int numOfDelEl;
            while (true)
            {
                try
                { 
                    Console.Write("Введите номер элемента, который хотите удалить: ");
                    numOfDelEl = int.Parse(Console.ReadLine());
                    if (numOfDelEl < 0 || numOfDelEl > myArr.Length)
                    {
                        Console.WriteLine("!!!! Error: Номер элемента вне границ массива и будет вставлен в начало");
                        numOfDelEl = 0;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
                }
            }

            int[] newArr = new int[myArr.Length - 1];

            for (int i = 0; i < numOfDelEl; i++)
                newArr[i] = myArr[i];

            for (int i = numOfDelEl; i < newArr.Length; i++)
                newArr[i] = myArr[i + 1];

            myArr = newArr;
        }




    }
}
