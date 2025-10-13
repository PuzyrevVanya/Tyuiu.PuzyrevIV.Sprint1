using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint1.Task7.V1.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 6;
            double c = 8;
            double wait = 2.150883403395439;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);

        }
    }
}
