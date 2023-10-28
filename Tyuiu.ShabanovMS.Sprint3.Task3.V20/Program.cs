using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint3.Task3.V20.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл foreach, которая вычисляет            *");
            Console.WriteLine("* количество букв 'f' в строке                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gfft ntf f opf";
            char chr = 'f';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомый символ: " + chr);

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество символов: " + ds.GetCharCount(value,chr)); 
            Console.ReadKey();
        }
    }
}
