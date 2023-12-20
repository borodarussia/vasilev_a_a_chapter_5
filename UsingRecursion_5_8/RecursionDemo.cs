using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingRecursion_5_8
{
    internal class RecursionDemo
    {
        // метод для вычисления факториала числа:
        static int factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            return n * factorial(n - 1);
        }
        // метод для вычисления чисел Фибоначчи:
        static int fibs(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return fibs(n - 1) + fibs(n - 2);
        }
        // метод для вычисления суммы чисел:
        static int sum(int n)
        {
            if (n == 0)
                return 0;
            return n + sum(n - 1);
        }
        // метод для отображения содержимого массива:
        static void show(int[] a, int k)
        {
            // отображения значения элемента массива:
            Console.Write(a[k] + " ");
            // если элемент в массиве последний:
            if (k == a.Length - 1)
                Console.WriteLine();
            else
                // рекурсивный вызов метода:
                show(a, k + 1);
        }
        // перегрузка метода для отображения содержимого массива:
        static void show(int[] a)
        {
            // вызов версии метода с двумя аргументами
            show(a, 0);
        }
        // главный метод программы:
        static void Main(string[] args)
        {
            Console.WriteLine("Факториал числа:");
            for (int i = 1; i <= 10; i++)
                // вычисление факториала числа:
                Console.WriteLine(i.ToString() + "! = " + factorial(i).ToString());

            Console.Write("\nЧисла Фибоначчи: ");
            for (int i = 1; i <= 10; i++)
                // вычисление чисел фибоначчи:
                Console.Write(fibs(i).ToString() + " ");

            Console.WriteLine("\n\nСумма чисел от 1 до 100: " + sum(100).ToString());

            // числовой массив:
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            Console.WriteLine("\nЧисловой массив: ");
            // отображение всех элементов массива:
            show(A);
            Console.WriteLine("\nЭлементы числового массива, начиная с третьего:");
            // отображение элементов, начиная с третьего:
            show(A, 2);

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
