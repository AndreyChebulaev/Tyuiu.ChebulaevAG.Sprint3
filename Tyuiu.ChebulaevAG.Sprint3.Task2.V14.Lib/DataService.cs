using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChebulaevAG.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 0;
            do
            {
                multSeries = multSeries + (Math.Pow(value / startValue, 3));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
