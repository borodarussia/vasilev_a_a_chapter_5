using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingAnArrayAsAnArgumentToAMethod_5_3
{
    internal class ArrayToMethDemo
    {
        // метод для заполнения массива случайными числами:
        static void fillRand(int[] nums)
        {
            // объект для генерирования случайных чисел:
            Random rnd = new Random();
            // заполнение массива случайными числами:
            for (int k = 0; k < nums.Length; k++)
                nums[k] = rnd.Next(1, 101);
        }

        // метод для отображения одномерного целочисленного массива:
        static void showArray(int[] nums)
        {
            // перебор элементов массива:
            for (int i = 0; i < nums.Length; i++)
                // отображение значения элемента:
                Console.Write("| {0}", nums[i]);
            Console.WriteLine("|");
        }
        // метод для отображения двумерного целочисленного массива:
        static void showArray(int[,] nums)
        {
            // перебор строк в массиве:
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                    // перебор элементов в строке
                    Console.Write("{0,3}", nums[i, j]);
                // переход к новой строке:
                Console.WriteLine();
            }
        }
        // метод для вычисления наименьшего элемента в массиве:
        static int findMin(int[] nums)
        {
            // локальная переменная
            int s = nums[0];
            // поиск наименьшего значения:
            for (int i = 1; i < nums.Length; i++)
                // если проверяемый элемент имеет значение,
                // меньшее текущего значения переменно s:
                if (nums[i] < s)
                    s = nums[i];
            // результат метода
            return s;
        }
        // главный метод программы:
        static void Main(string[] args)
        {
            // одномерные массивы:
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] B = new int[5];

            // двумерный массив:
            int[,] C = { 
                { 1, 2, 3, 4}, 
                { 5, 6, 7, 8}, 
                { 9, 10, 11, 12} };

            // массив заполняется случайными числами:
            fillRand(B);

            Console.WriteLine("Одномерный массив A:");
            // отображение массива A:
            showArray(A);

            Console.WriteLine("Одномерный массив B:");
            // отображение массива B:
            showArray(B);

            // поиск наименьшего элемента:
            int m = findMin(B);
            Console.WriteLine("Наименьшее значение массива B: {0}", m);

            Console.WriteLine("Двумерный массив C:");
            // отображение массива C:
            showArray(C);

            // Завершение программы
            Console.Write("Для завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
