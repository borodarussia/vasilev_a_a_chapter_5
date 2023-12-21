using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_chapter_5
{
    internal class Program
    {
        /*
         * Программма со статическим методом,
         * которому передается текст и произвольное количество символьных аргументов.
         * Результатом возвращается текст,
         * который получается добавлением в конец исходного текста
         * (первый аргумент метода) символьных значений,
         * переданных аргументами методу.
         */
        static string modifStr(string str, params char[] symbs)
        {
            string mdfStr = str + " - ";

            for (int i = 0; i < symbs.Length; i++)
                mdfStr += symbs[i].ToString();

            return mdfStr;
        }
        static void Main(string[] args)
        {
            string firstStr = modifStr("Проверочный текст 1-го варианта", 'б', 'с');
            Console.Write(firstStr);

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
