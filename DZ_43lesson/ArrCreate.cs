using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_43lesson
{
    static class ArrCreate
    {

        /// <summary>
        /// Ввод длинны массива.
        /// </summary>
        /// Метод используется в самом начале программы
        public static int EnterMasslenght()
        {
            int massLenght= 0;

            while (true)
            {
                try
                {
                    Console.Write("\nВведите длину массива: ");
                    massLenght = int.Parse(Console.ReadLine());
                    Console.Clear();
                    return massLenght;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\tНеверный формат!!! Введите еще раз");
                }
            }
        }



        /// <summary>
        /// 1. Ввод массива
        /// </summary>
        /// Реализован ввод массива с помощью рекурсии!!
        public static void EnterMass(ref int[] Arr, int indexMass)
        {
            if (indexMass >= Arr.Length)
                return;
            try
            {
                Console.Write($"\tВведите элемент под номером [{indexMass}] : ");
                Arr[indexMass] = int.Parse(Console.ReadLine());
                indexMass++;
            }
            catch
            {
                Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
            }


            EnterMass(ref Arr, indexMass);

            // Обычная реализация

                    //for (int i = 0; i < Arr.Length; i++)
                    //{
                    //    while (true)
                    //    {
                    //        try
                    //        {
                    //            Console.Write($"Введите элемент под номером [{i}] : ");
                    //            Arr[i] = int.Parse(Console.ReadLine());
                    //            break;
                    //        }
                    //        catch
                    //        {
                    //            Console.WriteLine("\t!!!! Error: Неверный формат. Введите еще раз");
                    //        }
                    //    }
                    //}
        }



        /// <summary>
        /// 2. Автоматическое заполнение массива + вывод
        /// </summary>
        public static void AutoEnterMass(ref int[] Arr)
        {
            Console.WriteLine(". Автоматическое заполнение массива + вывод \n" +
                "\n\tРезультаты:");

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i;
                Console.WriteLine($"\t\tmyArr[{i}] = {Arr[i]}\t");
            }
        }



        /// <summary>
        /// 3. Вывод массива
        /// </summary
        public static void PrintMass(in int[] Arr)
        {
            Console.WriteLine(". Вывод массива\n\n" +
                "\tВведенный массив: ");

            for (int i = 0; i < Arr.Length; i++)
                Console.WriteLine($"\t\tmyArr[{i}] = {Arr[i]}\t");
        }

    }
}
