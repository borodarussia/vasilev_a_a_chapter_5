using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2_chapter_5
{
    internal class SumSquareNaturalValue
    {
        /*
         * Программа для вычисления суммы квадратов натуральных чисел
         * Аргумент метода - натуральное число
         * Предложите версию метода без рекурсии и с рекурсией
         */

        // метод с рекурсией
        static int squareSumRecursion(int n)
        {
            if (n == 1)
                return 1;

            return n * n + squareSumRecursion(n -1);
        }
        // метод без рекурсии
        static int squareSum(int n)
        {
            int res = 0;

            for (int i = n; i > 0; i--)
                res += i * i;

            return res;
        }

        static void Main(string[] args)
        {
            // сумма квадратов натуральных чисел
            Console.WriteLine("Сумма квадратов натуральных чисел: ");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i.ToString() + " = "
                    + squareSumRecursion(i).ToString() + " - "
                    + squareSum(i));

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
