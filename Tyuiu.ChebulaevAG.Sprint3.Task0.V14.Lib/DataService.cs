using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChebulaevAG.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries = MultiplySeries + Math.Pow(1.0 / Math.Pow(startValue, value), -1);
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
