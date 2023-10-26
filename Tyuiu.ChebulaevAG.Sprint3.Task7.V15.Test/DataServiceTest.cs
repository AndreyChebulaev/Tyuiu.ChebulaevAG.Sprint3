using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint3.Task7.V15.Lib;

namespace Tyuiu.ChebulaevAG.Sprint3.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 3.63;
            valueWaitArray[1] = -11.70;
            valueWaitArray[2] = -14.02;
            valueWaitArray[3] = -5.24;
            valueWaitArray[4] = 1.32;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = -1.32;
            valueWaitArray[7] = 5.24;
            valueWaitArray[8] = 14.02;
            valueWaitArray[9] = 11.70;
            valueWaitArray[10] = -3.63;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
