using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3_chapter_5
{
    internal class ArrayCopy
    {
        /*
         * Программа со статическим методом, которому аргументом передается
         * целочисленный массив и целое число.
         * Результатом метод возвращает ссылку на новый массив,
         * который получается из исходного массива (переданного первым
         * аргументом методу), если в нем взять несколько начальных элементов.
         * Количество элементов, которые нудно взять из исходного массива,
         * определяются вторым аргументом метода.
         * Если второй аргумент метода больше длины массива,
         * переданного первым аргументом, то методом создается копия исходного
         * массива и возвращается ссылка на эту копию
         */ 

        // базовый метод для копирования массива
        static int[] arrayCopy(int[] arr, int n)
        {
            // объявление переменной, которая описывает длину массива
            int arrayLength = 0;

            // если длина массива arr меньше n,
            // то длина нового массива равна длина входного массива arr
            // иначе - длина нового массива равна n
            if (arr.Length < n)
                arrayLength = arr.Length;
            else
                arrayLength = n;

            int[] nums = new int[arrayLength];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = arr[i];

            return nums;
        }

        // перегруженный метод для копирования всего массива
        static int[] arrayCopy(int[] arr)
        {
            return arrayCopy(arr, arr.Length);
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

        static void Main(string[] args)
        {
            // объявление исходного массива
            int[] checkArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Исходный массив:\t");
            showArray(checkArray);


            // первый вариант копирования массива
            int[] frstArrCopy = arrayCopy(checkArray, 3);

            Console.Write("Первая копия массива:\t");
            showArray(frstArrCopy);

            // второй вариант копирования массива
            int[] sndArrCopy = arrayCopy(checkArray, 20);

            Console.Write("Вторая копия массива:\t");
            showArray(sndArrCopy);

            // третий вариант копирования массива
            int[] thrdArrCopy = arrayCopy(checkArray);

            Console.Write("Третья копия массива:\t");
            showArray(thrdArrCopy);

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
