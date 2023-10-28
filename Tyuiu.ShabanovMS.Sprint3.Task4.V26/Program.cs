using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint3.Task4.V26.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(cos(x)-sin(x))/x. При х = 0 пропустить значение.             *");
            Console.WriteLine("* Полученные значения суммировать.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + res);
            Console.ReadKey();
        }
    }
}
