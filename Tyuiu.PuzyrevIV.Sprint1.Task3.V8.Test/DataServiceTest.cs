using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PuzyrevIV.Sprint1.Task3.V8.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double StartAmount = 2500;
            double Percent = 20;
            double TimeDays = 30;
            double wait = 2541.1;
            var res = ds.IncomeAmount(StartAmount, Percent, TimeDays);
            Assert.AreEqual(wait, res);
        }
    }
}
