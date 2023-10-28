using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint3.Task3.V20.Lib;
namespace Tyuiu.ShabanovMS.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "gfft ntf f opf";
            char chr = 'f';
            double res = ds.GetCharCount(str, chr);
            int wait = 5;
            Assert.AreEqual(res, wait);
        }
    }
}
