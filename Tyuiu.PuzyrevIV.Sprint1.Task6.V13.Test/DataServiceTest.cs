using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PuzyrevIV.Sprint1.Task6.V13.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.CheckWordsAlphabet;
            string wait = "123";
            Assert.AreEqual(wait ,res);
        }
    }
}
