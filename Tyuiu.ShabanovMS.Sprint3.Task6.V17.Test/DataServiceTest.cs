using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint3.Task6.V17.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSum()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 20;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 43;
            Assert.AreEqual(res, wait);
        }
    }
}
