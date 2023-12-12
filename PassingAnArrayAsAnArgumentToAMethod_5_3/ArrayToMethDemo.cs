using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingAnArrayAsAnArgumentToAMethod_5_3
{
    internal class ArrayToMethDemo
    {
        // методо для заполнения массива случайными числами:
        static void fillRand(int[] nums)
        {
            // объект для генерирования случайных чисел:
            Random rnd = new Random();
            // заполнение массива случайными числами:
            for (int k = 0; k < nums.Length; k++)
                nums[k] = rnd.Next(1, 101);
        }


        static void Main(string[] args)
        {
            // одномерный массив:
            int[] B = new int[5];

            // массив заполняется случайными числами:
            fillRand(B);
            // Завершение программы
            Console.Write("Для завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
