using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43lesson
{
    internal class ArrChange
    {

        /// <summary>
        /// Изменение длинны массива
        /// </summary
        public static void Resize(ref int[] myArr)
        {
            Console.WriteLine(". Изменение длинны массива\n");

            Console.WriteLine($"\tИзначальная длина: {myArr.Length}");
            int newSize;
            while (true)
            {
                try
                {
                    Console.Write("\tВведите новую длину массива: ");
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
                Console.WriteLine("\n\tВведите новые элементы:");

            for (int i = myArr.Length; i < newSize; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"\t\tЭлемент mass[{i}]: ");
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
        /// Добавление элемента в массив
        /// </summary>
        public static void Insert(ref int[] myArr)
        {
            Console.WriteLine(". Добавление элемента\n");
            int numOfNewEl;
            while (true)
            {
                try
                {
                    Console.Write("\tВведите номер в массиве, куда хотите вставить новый элемент: ");
                    numOfNewEl = int.Parse(Console.ReadLine());
                    if (numOfNewEl < 0 || numOfNewEl > myArr.Length)
                    {
                        Console.WriteLine("\t!!!! Error: Номер элемента вне границ массивa");
                        return;
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
                Console.Write($"\tВведите новый элемент [{numOfNewEl}]: ");
                int newEl = int.Parse(Console.ReadLine());
                newArr[numOfNewEl] = newEl;
                Console.WriteLine("\tМассив увеличился на 1 элемент" +
                    $"\n\tmyArr[{numOfNewEl}] = {newEl}");
            }
            catch
            {
                Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
            }

            for (int i = 0; i < numOfNewEl; i++)
                newArr[i] = myArr[i];

            for (int i = numOfNewEl + 1; i < newArr.Length; i++)
                newArr[i] = myArr[i - 1];

            myArr = newArr;

        }



        /// <summary>
        /// Удаление элемента из массива
        /// </summary>
        public static void RemoveEl(ref int[] myArr)
        {
            Console.Write(". Удаление элемента\n");

            int numOfDelEl;

            while (true)
            {
                try
                {
                    Console.Write("\tВведите номер элемента, который хотите удалить: ");
                    numOfDelEl = int.Parse(Console.ReadLine());
                    if (numOfDelEl < 0 || numOfDelEl > myArr.Length)
                    {
                        Console.WriteLine("\t!!!! Error: Номер элемента вне границ массива.");
                        return;
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
