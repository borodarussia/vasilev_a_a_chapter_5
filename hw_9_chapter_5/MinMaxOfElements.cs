using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9_chapter_5
{
    internal class MinMaxOfElements
    {
        /*
         * Программа со статическим методом, аргументом которому
         * передается произвольное количество целочисленных аргументов.
         * Результатом метод возвращает массив из двух элементов:
         * это значения наибольшего и анименьшего значений среди аргументов,
         * переданных методу
         */

        static int[] minMaxValues(params int[] values)
        {
            if (values.Length == 0)
                throw new ArgumentException();

            int minValue = values[0];
            int maxValue = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if(minValue > values[i])
                    minValue = values[i];
                if(maxValue < values[i])
                    maxValue = values[i];
            }

            int[] resArr = { minValue, maxValue };
            return resArr;
        }

        static void showArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                    Console.Write("[ {0} | ", arr[i]);
                else if (i == arr.Length - 1)
                    Console.WriteLine("{0} ]", arr[i]);
                else
                    Console.Write("{0} | ", arr[i]);
            }
        }


        static void Main(string[] args)
        {
            int[] minMaxFirstTry = minMaxValues(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            int[] minMaxSecondTry = minMaxValues(5);
            int[] minMaxThirdTry = minMaxValues(6, 5, 123, 6, 89734, 54682, 7484);


            showArray(minMaxFirstTry);
            showArray(minMaxSecondTry);
            showArray(minMaxThirdTry);


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
