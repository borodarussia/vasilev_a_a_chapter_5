using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithAnArbitraryNumberOfArguments_5_9
{
    internal class ParamsDemo
    {
        // метод для вычисления суммы чисел:
        static int sum(params int[] a)
        {
            // локальная переменная (значение суммы):
            int res = 0;

            // перебор аргументов метода:
            for (int i = 0; i < a.Length; i++)
                // прибавление слагаемого к сумме:
                res += a[i];
            // результат метода
            return res;
        }
        // метод для извлечения символов из текста:
        static string getText(string t, params int[] a)
        {
            // начальное значение формируемой текстовой строки:
            string res = "";
            // перебор аргументов метода:
            for (int i = 0; i < a.Length; i++)
                // проверка на то, что значение индекса символа меньше длины строки
                if (a[i] < t.Length)
                    // добавление символа в текст:
                    res += t[a[i]];
            // результат метода:
            return res;
        }
        // метод для отображения значения аргументов:
        static void show(int[]a, params char[] b)
        {
            // количество элементов в числовом массиве:
            Console.Write("Чисел " + a.Length.ToString() + ": ");
            // значения элементов в числовом массиве:
            for (int i = 0; i < a.Length - 1; i++)
                Console.Write(a[i].ToString() + " ");
            Console.WriteLine("и " + a[a.Length - 1].ToString());
            // количество символьных элементов
            Console.Write("Символов " + b.Length.ToString() + ": ");
            // значения символьных аргументов:
            for (int i = 0; i < b.Length - 1; i++)
                Console.Write(b[i].ToString() + " ");
            Console.WriteLine("и " + b[b.Length - 1].ToString());
        }
        // главный метод программы
        static void Main(string[] args)
        {
            // примеры вызова методов.
            // вычисление суммы чисел:
            Console.WriteLine("Сумма чисел: " + sum(1, 6, 9, 2, 4));
            Console.WriteLine("Сумма чисел: " + sum(5, 1, 2));
            // формирование текста:
            Console.WriteLine(getText("Раз два три", 0, 10, 8, 1));
            Console.WriteLine(getText("Бревно", 3, 5, 1, 5, 4));
            //отображение аргументов:
            show(new int[] { 1, 3, 5}, 'A', 'B', 'C', 'D', 'E');
            show(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C', 'D');



            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
