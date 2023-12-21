using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_8_chapter_5
{
    internal class ArrayCreate
    {
        /*
         * Программа с перегруженным статическим методом.
         * Если аргументом методу передается два целых числа,
         * то результатом возвращается ссылка на целочисленный массив,
         * состоящий из натуральных чисел, 
         * а первое и последнее число в массиве определяется аргументами метода.
         * Например, если передать аргументами числа 2 и 4,
         * то результатом будет массив из чисел 2, 3 и 4.
         * Если аргументами методу передаются два символьных значения,
         * то результатом возвращается ссылка на массив,
         * состоящий из последовательности символов,
         * а первый и последний символы определяются аргументами метода.
         * Например, если передать аргументами методу символы 'B' и 'D',
         * то в результате получим массив из символов 'B', 'C', 'D'.
         */

        static int[] createArray(int startValue, int endValue)
        {
            int arrLength = endValue - startValue + 1;
            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
                arr[i] = startValue + i;

            return arr;
        }

        static char[] createArray(char startSymb, char endSymb)
        {
            int arrLength = (int)endSymb - (int)startSymb + 1;
            char[] arr = new char[arrLength];
            for (int i = 0; i < arrLength; i++)
                arr[i] = (char)((int)startSymb + i);

            return arr;
        }

        // метод для отображения массива
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
        // метод для отображения массива
        static void showArray(char[] arr)
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
            int[] checkValueArr = createArray(2, 10);

            Console.Write("Массив из чисел:\t");
            showArray(checkValueArr);


            char[] checkSymbArr = createArray('A', 'L');

            Console.Write("Массив из символов:\t");
            showArray(checkSymbArr);


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
