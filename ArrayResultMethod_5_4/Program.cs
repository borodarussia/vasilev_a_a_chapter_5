using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResultMethod_5_4
{
    internal class Program
    {
        // метод для создания массива с числами фибоначчи:
        static int[] fibs(int n)
        {
            // создание массива:
            int[] nums = new int[n];
            // первый элемент массива:
            nums[0] = 1;
            // если массив из одного элемента:
            if (nums.Length == 1)
                return nums;
            // второй элемент массива:
            nums[1] = 1;
            // заполнение элементов массива:
            for (int i = 2; i < nums.Length; i++)
                // значение элемента массива равно сумме значений
                // двух предыдущих элементов:
                nums[i] = nums[i - 1] + nums[i - 2];

            // результат метода - ссылка на массив:
            return nums;
        }

        // метод для создания массива со случайными символами:
        static char[] rands(int n)
        {
            // объект для генерирования случайных чисел:
            Random rnd = new Random();
            // создание массива
            char[] symbs = new char[n];
            // заполнение массива:
            for (int i = 0; i < symbs.Length; i++)
                // значение элемента - случайный символ:
                symbs[i] = (char)('A' + rnd.Next(26));
            // результат метода - ссылка на массив:
            return symbs;
        }
        // метод для создания двумерного массива с нечетными числами:
        static int[,] odds(int m, int n)
        {
            // создание двумерного массива:
            int[,] nums = new int[m, n];
            // локальная переменная:
            int val = 1;
            // перебор строк массива:
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0;  j < nums.GetLength(1); j++)
                {
                    // значение элемента:
                    nums[i, j] = val;
                    // значение для следующего элемента:
                    val += 2;
                }
            }
            // результат метода - ссылка на массив:
            return nums;
        }
        // главный метод программы:
        static void Main(string[] args)
        {
            // переменная для целочисленного массива:
            int[] A;
            // переменная для символьного массива:
            char[] B;
            // переменная для двумерного массива:
            int[,] C;
            // создание массив с числами Фибоначчи:
            A = fibs(10);
            Console.WriteLine("Числа Фибоначчи:");
            // отображение содержимого массива:
            foreach (int s in A)
                Console.Write("| {0}", s);
            Console.WriteLine("|");
            // создание массив со случайными символами:
            B = rands(8);
            Console.WriteLine("Случайные символы:");
            // отображение содержимого массива:
            foreach (char s in B)
                Console.Write("| {0}", s);
            Console.WriteLine("|");
            // создание двумерного массива с нечетными числами:
            C = odds(4, 6);
            Console.WriteLine("Двумерный массив:");
            // отображение содержимого двумерного массива:
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                    Console.Write("{0, 4}", C[i, j]);
                Console.WriteLine();
            }
            // Завершение программы
            Console.Write("Для завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
