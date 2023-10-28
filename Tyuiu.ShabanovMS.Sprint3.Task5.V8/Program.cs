using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint3.Task5.V8.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вчисляет сумму ряда, с импользованием       *");
            Console.WriteLine("* вложенных циклов                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine("Старт шага первого ряда: " + startValue1);
            Console.WriteLine("Конец шага первого ряда: " + stopValue1);
            Console.WriteLine("Старт шага второго ряда: " + startValue2);
            Console.WriteLine("Конец шага второго ряда: " + stopValue2);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + ds.GetSumSumSeries(startValue1, stopValue1, startValue2, stopValue2));
            Console.ReadKey();
        }
    }
}
