using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7_chapter_5
{
    internal class ReplaceElementsInArray
    {
        /*
         * Программа со статическим методом, аргументом которому
         * передается одномерный символьный массив.
         * В результате вызова метода элементы массива попарно меняются местами:
         * первый - с последним, второй - с предпоследним и т.д.
         */

        static char[] chngPositionsOfElements(ref char[] arr)
        {
            char[] mdrnArr = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                mdrnArr[i] = arr[(arr.Length - 1) - i];

            arr = mdrnArr;

            return arr;
        }

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
            char[] checkArr = { 'a', 'b', 'c','d','e','f','g','h','i','j'};

            Console.Write("Исходный массив:\t");
            showArray(checkArr);

            checkArr = chngPositionsOfElements(ref checkArr);

            Console.Write("Модифицированный массив:\t");
            showArray(checkArr);

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
