using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint3.Task2.V6.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу  используя цикл do-while, которая вычисляет          *");
            Console.WriteLine("* произведение ряда по формуле, при a = 0,25                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Значение a: " + value);
            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда: " + ds.GetMultiplySeries(value,startValue,stopValue));
            Console.ReadKey();
        }
    }
}
