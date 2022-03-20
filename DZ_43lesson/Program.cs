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
            /* Console.WriteLine("Суть программы: реализовать метод изменяющий кол-во элементов массива " +
                "\n(метод должен иметь возможность увеличить или уменьшиить кол-во элементов массива)"); */

            Line();
            Line();
            Line();

            //Ввод длинны массива
            int massLenght;
            while (true)
            {
                try
                {
                    Console.Write("\nВведите длину массива: ");
                    massLenght = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\tНеверный формат!!! Введите еще раз");
                }
            }

            //создание массива
            int[] myArr = new int[massLenght];

            Line();

            Console.WriteLine("\nВыберите действие:" +
                "\n1.\tЗаполнить массив" +
                "\n2.\tВывести массив в консоль" +
                "\n3.\tАвтоматическое заполнение массива и вывод его в консоль" +
                "\n4.\tИзменить размер существующего массива" +
                "\n5.\tДобавить элемент в массив" +
                "\n6.\tУдалить элемент массива" +
                "\nEscape.\tВыход");

            //вызов метода меню
            Menu(ref myArr, ref massLenght);
        }


        //Реализация меню
        static void Menu(ref int[] Arr, ref int massLenght)
        {
            Line();
            Console.Write("\t\n");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            Console.WriteLine(". Ваш выбор \n"); // вывод после ввода числа пользователем

            bool working = true;
            while (working)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D1:
                        {
                            EnterMass(ref Arr);
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            PrintMass(Arr);
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            AutoEnterMass(ref Arr);
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Resize(ref Arr);
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Insert(ref Arr);
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            RemoveEl(ref Arr);
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            working = false;
                            Console.WriteLine("ВЫХОД\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("!!!! Error: Неизвестная команда");
                            Menu(ref Arr, ref massLenght);
                            break;
                        }

                }
            }
        }


        /// <summary>
        /// Ввод массива
        /// </summary>
        static void Line()
        {
            Console.WriteLine("-----------------");
        }


        /// <summary>
        /// 1. Ввод массива
        /// </summary>
        static void EnterMass(ref int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Введите элемент под номером [{i}] : ");
                        Arr[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
                    }
                }
            }
        }


        /// <summary>
        /// 2. Автоматическое заполнение массива + вывод
        /// </summary>
        static void AutoEnterMass(ref int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i;
                Console.WriteLine($"myArr[{i}] = {Arr[i]}\t");
            }
        }

        /// <summary>
        /// 3. Вывод массива
        /// </summary
        static void PrintMass(int[] Arr)
        {
            Console.WriteLine("Введенный массив: ");

            for (int i = 0; i < Arr.Length; i++)
                Console.WriteLine($"myArr[{i}] = {Arr[i]}\t");
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
