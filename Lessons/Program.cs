using System;

namespace Lessons
{
    class StatMethDemo
    {
        // Статический метод для отображения текста,
        // переданного аргументов методу%
        static void show(string message)
        {
            Console.WriteLine(message);
        }

        // Статический метод для вычилсения факториала числа,
        // переданного аргемнтом методу
        static int factorial(int n)
        {
            // локальная переменная:
            int s = 1;

            // вычисление:
            for (int k = 1; k <= n; k++)
            {
                s *= k;
            }

            // Результат метода
            return s;
        }

        // Статический метод для возведения числа в степень
        // Число и степень передаются аргументами методу:
        static double power (double x, int n)
        {
            // локальная переменная:
            double s = 1;
            for (int k = 1; k <= n; k++)
            {
                s *= x;
            }

            // результат метода:
            return s;
        }

        // главный метод программы:
        static void Main()
        {
            show("Начинаем вычисления");
            int m = 5; // целочисленные переменные
            double z = 3, num; // действительные переменные
            // вычисление факториала числа:
            show(m + "! = " + factorial(m));
            // число в степени
            num = power(z, m);
            // отображение сообщения вызовом статического метода:
            show(z + " в степени " + m + ": " + num);

            Console.Write("Для закрытия программы - нажмите Enter...");
            Console.ReadLine();
        }
    }
}
