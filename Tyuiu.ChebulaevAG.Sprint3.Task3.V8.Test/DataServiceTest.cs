using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint3.Task3.V8.Lib;

namespace Tyuiu.ChebulaevAG.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string value = "vc,x12fc fc!e";
            int wait = 12;

            int res = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, res);
        }
    }
}
