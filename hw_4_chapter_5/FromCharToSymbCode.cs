using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4_chapter_5
{
    internal class FromCharToSymbCode
    {
        /*
         * Программа со статическим методом, аргументом которому передается символьный массив,
         * а результатом возвращается ссылка на целочисленный массив,
         * состоящий из кодов символов из массива-аргумента
         */

        // метод для преобразования массива
        static int[] fromSymbToCode(char[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                result[i] = (int)arr[i];

            return result;
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

            char[] symbArr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            Console.Write("Исходный массив:\t");
            showArray(symbArr);

            int[] codeArr = fromSymbToCode(symbArr);

            Console.Write("Преобразованный массив:\t");
            showArray(codeArr);


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
