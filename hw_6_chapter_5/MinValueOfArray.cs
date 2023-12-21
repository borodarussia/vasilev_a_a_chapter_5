using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_6_chapter_5
{
    internal class MinValueOfArray
    {
        /*
         * Программа со статическим методом, аргументом которому
         * передается двумерный целочисленный массив. У метода, кроме
         * аргумента-массива, есть два неинициализированных аргумента.
         * Результатом метод возвращает значение наибольшего элемента в массиве.
         * Неинициализированным аргументам присваиваются значения индексов
         * этого элемента.
         */

        static int minValueOfArray(int[,] arr, out int rowIndex, out int columnIndex)
        {
            int minValue = arr[0, 0];
            rowIndex = 0;
            columnIndex = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minValue > arr[i, j])
                    {
                        minValue = arr[i, j];
                        rowIndex = i;
                        columnIndex = j;
                    }
                        
                }
            return minValue;
        }
        static void Main(string[] args)
        {
            int[,] checkArray = {
                {123, 221, 365, 41, 5 },
                {658, 34, 6, 89, 13 }, 
                {59, 96, 13, 12, 872 } };

            int rowIndex, columnIndex;
            int minValueOfCheckArray = minValueOfArray(checkArray, out rowIndex, out columnIndex);

            Console.WriteLine("Минимальное значение массива checkArray:\t{0}\nИндекс строки:\t{1}\nИндекс колонки:\t{2}",
                minValueOfCheckArray, rowIndex, columnIndex);
            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
