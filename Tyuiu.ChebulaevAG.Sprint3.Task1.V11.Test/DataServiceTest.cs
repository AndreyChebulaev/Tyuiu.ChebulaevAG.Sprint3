using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint3.Task1.V11.Lib;

namespace Tyuiu.ChebulaevAG.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 10.429;

            Assert.AreEqual(wait, res);
        }
    }
}
