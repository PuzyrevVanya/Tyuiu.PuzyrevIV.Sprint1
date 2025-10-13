using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint1.Task6.V13.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "а б в г д";
            DataService ds = new DataService();
            string res = ds.CheckWordsAlphabet(strTest);
            string wait = "АБВГД";
            Assert.AreEqual(wait, res);
        }
    }
}
