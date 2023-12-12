using System;

namespace OverloadingStaticMethods_5_2
{
    class OverloadMethDemo
    {
        // Версия статического метода для отображения текста
        // (с одним текстовым аргументом):
        static void show(string txt)
        {
            Console.WriteLine($"Текст: {txt}");
        }

        /// <summary>
        /// Версия статического метода для отображения
        /// целого числа
        /// </summary>
        /// <param name="num"> Аргумент метода</param>
        static void show(int num)
        {
            Console.WriteLine($"Действительное число: {num}");
        }

        /// <summary>
        /// Версия статического метода для отображения
        /// действительного числа
        /// </summary>
        /// <param name="num">Аргумент метода</param>
        static void show(double num)
        {
            Console.WriteLine($"Действительное число: {num}");
        }

        /// <summary>
        /// Версия статического метода для отображения символа
        /// </summary>
        /// <param name="s">Аргумент метода</param>
        static void show(char c)
        {
            Console.WriteLine($"Символ: {c}");
        }

        /// <summary>
        /// Версия статического метода для отображения числа и символа
        /// </summary>
        /// <param name="num">Целое число</param>
        /// <param name="c">Символ</param>
        static void show(int num, char c)
        {
            Console.WriteLine("Аргументы {0} и {1}", num, c);
        }

        // Главный метод программы:
        static void Main()
        {
            // Целочисленная переменная:
            int num = 5;

            // Действительная переменная:
            double z = 12.5;

            // Символьная переменная:
            char symb = 'W';

            // Символьный аргумент:
            show(symb);

            // Текстовый аргумент:
            show("Знакомство с перегрузкой методов");

            // Целочисленный аргумент:
            show(num);

            // Действительный аргумент:
            show(z);

            // Два аргумента
            show(num, 'Q');

            // Завершение программы
            Console.Write("Для завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
