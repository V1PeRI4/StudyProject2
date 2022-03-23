using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43lesson
{
    static class Menu
    {

        ////////////////////////////////////////////////////////////////////////////////
        //ГЛАВНОЕ МЕНЮ
        ////////////////////////////////////////////////////////////////////////////////
        private static void PrintMainMenu()
        {
            Console.Write("\t\t\tГЛАВНОЕ МЕНЮ"); 

            Console.WriteLine("\nВыберите подменю:" +
                "\n1.\tСоздание массива" +
                "\n2.\tИзменение массива" +
                "\n{Escape}.Выход");
        }
        public static void MainMenu(ref int[] Arr)
        {
            PrintMainMenu(); //Вывод пунктов меню

            Separators.Line();

            ConsoleKey consoleKey = Console.ReadKey().Key; //считывание кнопки для свича

            bool working = true;
            while (working)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D1:
                        {
                            
                            CreateArrMenu(ref Arr);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            
                            ChangeArrMenu(ref Arr);
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            PrintMainMenu();
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
                            Console.Clear();
                            Separators.Line();
                            Console.WriteLine("!!!! Error: Неизвестная команда");
                            Separators.Line();

                            MainMenu(ref Arr);
                            break;
                        }
                }
            }

        }



        ////////////////////////////////////////////////////////////////////////////////
        //МЕНЮ СОЗДАНИЯ МАССИВА
        ////////////////////////////////////////////////////////////////////////////////
        private static void PrintCreateArrMenu()
        {
            Console.WriteLine(".\t\tМЕНЮ СОЗДАНИЯ МАССИВА");
            Console.WriteLine("\nВыберите действие:" +
                "\n1.\tВвод массива" +
                "\n2.\tВывести массив" +
                "\n3.\tАвтоматическое заполнение массива и вывод его в консоль" +
                "\n{Escape}.Выход в главное меню");
        }
        public static void CreateArrMenu(ref int[] Arr)
        {
            int countIndex = 0; //добавление из-за рекурсивного ввода

            PrintCreateArrMenu(); //Вывод пунктов меню

            Separators.Line();

            ConsoleKey consoleKey = Console.ReadKey().Key; //Считывание кнопки для свича

            switch (consoleKey)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine(". Ввод массива\n"); //ввод осуществлен рекурсией, вывод этой строки находится тут
                        ArrCreate.EnterMass(ref Arr, countIndex);
                        Separators.PressEnterToContinue();
                        MainMenu(ref Arr);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        ArrCreate.PrintMass(Arr);
                        Separators.PressEnterToContinue();
                        MainMenu(ref Arr);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        ArrCreate.AutoEnterMass(ref Arr);
                        Separators.PressEnterToContinue();
                        MainMenu(ref Arr);
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                        MainMenu(ref Arr);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("!!!! Error: Неизвестная команда");
                        MainMenu(ref Arr);
                        break;
                    }
            }   
            
        }



        ////////////////////////////////////////////////////////////////////////////////
        //МЕНЮ ИЗМЕНЕНИЯ МАССИВА
        ////////////////////////////////////////////////////////////////////////////////
        private static void PrintChangeArrMenu()
        {
            Console.WriteLine(".\t\tМЕНЮ ИЗМЕНЕНИЯ МАССИВА");
            Console.WriteLine("\nВыберите подменю:" +
                "\n1.\tИзменение длинны массива" +
                "\n2.\tДобавить элемент в массив" +
                "\n3.\tУдалить элемент из массива" +
                "\n{Escape}.Выход");
        }
        public static void ChangeArrMenu(ref int[] Arr)
        {
            PrintChangeArrMenu(); //Вывод пунктов меню

            Separators.Line();

            ConsoleKey consoleKey = Console.ReadKey().Key; //Считывание кнопки для свича

            switch (consoleKey)
            {
                case ConsoleKey.D1:
                    {
                        ArrChange.Resize(ref Arr);
                        Separators.PressEnterToContinue();
                        MainMenu(ref Arr);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        ArrChange.Insert(ref Arr);
                        Separators.PressEnterToContinue();
                        MainMenu(ref Arr);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        ArrChange.RemoveEl(ref Arr);
                        Separators.PressEnterToContinue();
                        MainMenu(ref Arr);
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                        MainMenu(ref Arr);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("!!!! Error: Неизвестная команда");
                        MainMenu(ref Arr);
                        break;
                    }
            } 

        }

        

        ////////////////////////////////////

        
       


    }
}
