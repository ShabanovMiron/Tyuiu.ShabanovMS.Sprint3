using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint3.Task7.V28.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* на заданном диапазоне [-5;5]                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");




            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);


            int len = ds.GetMassFunction(startValue,stopValue).Length;


            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X    |    F(x)    |");
            Console.WriteLine("+----------+-----------+");
 
            for (int i = 0; i <+ len; i++)
            {
                Console.WriteLine("|{0 ,5:d}    |{1, 6:f2}      |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}
