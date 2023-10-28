using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShabanovMS.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            double k = startValue;
            do
            {
                multSeries = multSeries * ((Math.Pow(value, k) + 1) * Math.Cos(4));
                k++;
            }
            while (k <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
