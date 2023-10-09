using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint2.Task4.V11.Lib;

namespace Tyuiu.VolovikovMV.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 1, x = 1;
            Assert.AreEqual(11, ds.Calculate(x, y));
        }
    }
}
