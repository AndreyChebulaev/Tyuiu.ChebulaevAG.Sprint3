using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChebulaevAG.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue < stopValue)
            {
                multSeries = multSeries + (Math.Pow(value, startValue) + 0.5);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
