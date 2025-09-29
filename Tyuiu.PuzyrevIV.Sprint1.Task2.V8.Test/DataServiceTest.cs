﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PuzyrevIV.Sprint1.Task2.V8.Lib;


namespace Tyuiu.PuzyrevIV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 5;
            var res = ds.CalculatePerimetr(x, y);
            Assert.AreEqual(10, res);    
        }
    }
}
