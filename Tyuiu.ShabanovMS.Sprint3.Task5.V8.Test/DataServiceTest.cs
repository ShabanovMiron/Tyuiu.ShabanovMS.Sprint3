using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint3.Task5.V8.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(startValue1, stopValue1, startValue1, stopValue2);
            double wait = 31.401;
            Assert.AreEqual(res, wait);
        }
    }
}
