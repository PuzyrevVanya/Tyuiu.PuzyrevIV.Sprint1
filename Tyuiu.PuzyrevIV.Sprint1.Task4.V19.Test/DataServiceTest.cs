using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PuzyrevIV.Sprint1.Task4.V19.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
