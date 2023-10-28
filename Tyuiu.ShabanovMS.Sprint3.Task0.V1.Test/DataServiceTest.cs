using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint3.Task0.V1.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 4;
            double wait = 1935;
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(res, wait);
        }
    }
}
