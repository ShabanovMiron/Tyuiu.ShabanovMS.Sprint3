using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint3.Task1.V30.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 12;
            double wait = 3.589;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(res, wait);
        }
    }
}
