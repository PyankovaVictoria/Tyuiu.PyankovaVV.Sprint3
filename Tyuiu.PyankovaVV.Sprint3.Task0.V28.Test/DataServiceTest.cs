using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint3.Task0.V28.Lib;

namespace Tyuiu.PyankovaVV.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 181667.106;
            Assert.AreEqual(wait, res);
        }
    }
}
