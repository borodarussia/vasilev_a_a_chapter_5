using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanismForPassingArgumentsToMethod_5_5
{
    internal class ArgsDemo
    {
        // первый метод. аргумент - целое число:
        static void alpha(int n)
        {
            // проверка значения аргумента:
            Console.WriteLine("В методе alpha(). На входе: " + n.ToString());
            // попытка изменения значения аргумента:
            n++;
            // проверка полученного значения аргумента:
            Console.WriteLine("В методе alpha(). На выходе: " + n.ToString());
        }
        // второй метод. аргумент - ссылка на массив:
        static void bravo(int[] n)
        {
            // проверка содержимого массива:
            Console.WriteLine("В методе bravo(). На входе: " + ArrayToText(n));
            // перебор элементов массива:
            for (int i = 0; i < n.Length; i++)
                n[i]++;
            // проверка содержимого массива:
            Console.WriteLine("В методе bravo(). На выходе: " + ArrayToText(n));
        }
        // третий метод. аргумент - ссылка на массив:
        static void charlie(int[] n)
        {
            // проверка содержимого массива:
            Console.WriteLine("В методе charlie(). На входе: " + ArrayToText(n));
            // создается новый массив:
            int[] m = new int[n.Length];
            // перебор элементов в массиве:
            for (int i = 0; i < n.Length; i++)
                // значение элемента в массиве
                m[i] = n[i] + 1;
            // попытка присвоить новое значение аргументу:
            n = m;
            // проверка содердимого массива:
            Console.WriteLine("В методе charlie(). На выходе " + ArrayToText(n));
        }
        // метод для преобразования массива в текст:
        static string ArrayToText(int[] n)
        {
            // текстовая переменная
            string res = "[" + n[0].ToString();
            // перебор элементов массива (кроме начального):
            for (int i = 1; i < n.Length; i++)
                res += ", " + n[i].ToString();
            // дописывание текста в текстовую переменную:
            res += "]";
            // результат метода - текстовая строка:
            return res;
        }

        static void Main(string[] args)
        {
            // переменная для передачи аргументом методу:
            int A = 100;
            // проверка значения переменной:
            Console.WriteLine("До вызова метода alpha(): A = " + A.ToString());
            // вызов метода:
            alpha(A);
            // проверка значения переменной:
            Console.WriteLine("После вызова метода alpha(): A = " + A.ToString());
            // массив для передачи аргументом методу:
            int[] B = { 1, 3, 5 };
            // проверка содержимого массива:
            Console.WriteLine("До вызова метода bravo(): B = " + ArrayToText(B));
            // вызров метода:
            bravo(B);
            // проверка содержимого массива:
            Console.WriteLine("После вызова метода bravo(): B = " + ArrayToText(B));
            // массив для передачи аргументом мтеоду:
            int[] C = { 2, 4, 6 };
            // проверка содержимого массива:
            Console.WriteLine("До вызова метода charlie(): C = " + ArrayToText(C));
            // вызов метода:
            charlie(C);
            // проверка содержимого массива:
            Console.WriteLine("После вызова метода charlie(): C = " + ArrayToText(C));
            // Завершение программы
            Console.Write("Для завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
