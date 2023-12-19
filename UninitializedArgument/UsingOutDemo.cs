using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UninitializedArgument
{
    internal class UsingOutDemo
    {
        // метод для вычисления значения наименьшего элемента
        // в массиве и его индекса:
        static int getMin(int[] nums, out int index)
        {
            // начальное значение для индекса:
            index = 0;
            // перебор элементов массива:
            for (int i = 1; i < nums.Length; i++)
                // если значение элемента массива меньше текущего
                // минимального значения:
                if (nums[i] < nums[index])
                    // новое значение для индекса:
                    index = i;
            // результат метода:
            return nums[index];
        }
        // главный метод программы:
        static void Main(string[] args)
        {
            // целочисленный массив:
            int[] A = { 12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15 };
            // отображение содержимого массива:
            foreach (int v in A)
                Console.Write("| {0} ", v);
            Console.WriteLine("|");

            // объявление переменных:
            int val, k;
            // вычисление элемента с наименьшим значением:
            val = getMin(A, out k);
            // отображение результатов:
            Console.WriteLine("Наименьшее значение: " + val.ToString());
            Console.WriteLine("Индекс элемента: " + k.ToString());
            Console.WriteLine("Проверка: A[{0}] = {1}", k, A[k]);
            // Завершение программы
            Console.Write("Для завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
