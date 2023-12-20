using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1_chapter_5
{
    internal class DoubleFactorial
    {
        /*
         * Программа для вычисления двойного факторилаа числа, переданного аргументом методу.
         * Последний множитель равен 1 для нечетного аргумента и равен 2 для четного аргумента
         * Предложите версию метода без рекурсии и с рекурсией.
         */

        // метод с рекурсией
        static int doubleFactorialRecursion(int n)
        {
            if (n < 0)
                throw new ArgumentException("Значение аргумента меньше 0");
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;

            return n * doubleFactorialRecursion(n - 2);
        }

        // метод без рекурсии
        static int doubleFactorial(int n)
        {
            int res = 1;

            if (n < 0)
                throw new ArgumentException("Значение аргумента меньше 0");
            //if (n == 0)
            //    res = 1;

            while (n > 1)
            {
                res *= n;
                n -= 2;
            }

            return res;
        }


        static void Main(string[] args)
        {
            // двойной факториал числа
            Console.WriteLine("Двойной факториал числа (рекурсия):");
            for (int i = 0; i <= 13; i++)
            {
                // вычисление двойного факториала числа:
                Console.WriteLine(i.ToString() + "!! = "
                    + doubleFactorialRecursion(i).ToString() + " - "
                    + doubleFactorial(i).ToString());
            }

            // doubleFactorialRecursion(-2);

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
