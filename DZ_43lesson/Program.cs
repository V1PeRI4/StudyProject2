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
            Console.WriteLine("Суть программы: реализовать метод изменяющий кол-во элементов массива " +
                "\n(метод должен иметь возможность увеличить или уменьшиить кол-во элементов массива)");

            Line();
            Line();
            Line();

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
            

            int[] myArr = new int [massLenght];

            Line();

            Console.WriteLine("\nВыберите действие:" +
                "\n1.\tЗаполнить массив" +
                "\n2.\tВывести массив в консоль" +
                "\n3.\tИзменить размер существующего массива" +
                "\nEscape.\tВыход");

            Menu(ref myArr, ref massLenght);

        }

        static void Menu(ref int[] Arr, ref int massLenght)
        {
            
            Line();
            Console.Write("\t\n");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            Console.WriteLine(". Ваш выбор \n");

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
                            Resize(ref Arr);
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
                            Console.WriteLine("Неизвестная команда!!!");
                            Menu(ref Arr, ref massLenght);
                            break;
                        }
                        
                }
            }
        }


        static void Line()
        {
            Console.WriteLine("-----------------");
        }


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
                        Console.WriteLine("\tНеверный формат!!! Введите еще раз");
                    }
                }
                
            }
        }

        static void PrintMass(int[] Arr)
        {
            Console.WriteLine("Введенный массив: ");
            for (int i = 0; i < Arr.Length; i++)
                Console.WriteLine($"myArr[{i}] = {Arr[i]}\t");
        }


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
                    Console.WriteLine("\tНеверный формат!!! Введите еще раз");
                }
            }
           

            int[] newArr = new int[newSize];

            if (newSize < myArr.Length)
            {
                for (int i = 0; i < newSize; i++)
                    newArr[i] = myArr[i];
            }
            else
            {
                for (int i = 0; i < myArr.Length; i++)
                    newArr[i] = myArr[i];

                Console.WriteLine("\nВведите новые элементы:");
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
                            Console.WriteLine("\tНеверный формат!!! Введите еще раз");
                        }
                    }
                    
                }
            }
            myArr = newArr;
        }
    }
}
