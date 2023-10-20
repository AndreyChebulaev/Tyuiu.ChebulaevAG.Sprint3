using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint3.Task0.V14.Lib;

namespace Tyuiu.ChebulaevAG.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}
