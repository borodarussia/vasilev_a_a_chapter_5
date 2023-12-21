using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5_chapter_5
{
    internal class AverageArray
    {
        /*
         * Программа со статическим методом, аругментом которому передается
         * целочисленный массив, а результатом возвращается среднее значение для элементов массива
         * (сумма значений элементов, деленная на количество элементов в массиве)
         */

        static double averageOfArr(int[] arr)
        {
            double averageValue = 0.0;

            for (int i = 0; i < arr.Length; i++)
                averageValue += (double)arr[i] / (double)arr.Length;

            return averageValue;
        }

        static void Main(string[] args)
        {
            int[] checkArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            double averageOfCheckArr = averageOfArr(checkArr);

            Console.WriteLine("Среднее значение массива checkArr:\t{0}", averageOfCheckArr);

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
