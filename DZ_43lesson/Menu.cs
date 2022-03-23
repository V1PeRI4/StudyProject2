using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43lesson
{
    static class Menu
    {

        private static void PrintMenu()
        {
            Console.WriteLine("\nВыберите действие:" +
                "\n1.\tЗаполнить массив" +
                "\n2.\tВывести массив в консоль" +
                "\n3.\tАвтоматическое заполнение массива и вывод его в консоль" +
                "\n4.\tИзменить размер существующего массива" +
                "\n5.\tДобавить элемент в массив" +
                "\n6.\tУдалить элемент массива" +
                "\n{Escape}.Выход");
        }

        public static void MainMenu(ref int[] Arr)
        {
            int countIndex = 0;

            Console.Write("\n\n{Enter}. Вывести меню в консоль\n");

            Separators.Line();

            ConsoleKey consoleKey = Console.ReadKey().Key;

            bool working = true;
            while (working)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine(". Ввод массива\n"); //ввод осуществлен рекурсией, вывод этой строки находится тут
                            ArrCreate.EnterMass(ref Arr, countIndex);
                            MainMenu(ref Arr);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            ArrCreate.PrintMass(Arr);
                            MainMenu(ref Arr);
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            ArrCreate.AutoEnterMass(ref Arr);
                            MainMenu(ref Arr);
                            break;
                        }
                    //case ConsoleKey.D4:
                    //    {
                    //        Resize(ref Arr);
                    //        MainMenu(ref Arr);
                    //        break;
                    //    }
                    //case ConsoleKey.D5:
                    //    {
                    //        Insert(ref Arr);
                    //        MainMenu(ref Arr);
                    //        break;
                    //    }
                    //case ConsoleKey.D6:
                    //    {
                    //        RemoveEl(ref Arr);
                    //        MainMenu(ref Arr);
                    //        break;
                    //    }
                    case ConsoleKey.Enter:
                        {
                            PrintMenu();
                            MainMenu(ref Arr);
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
                            MainMenu(ref Arr);
                            break;
                        }
                }   //end of switch
            }   //end of for
        }



       



    }
}
