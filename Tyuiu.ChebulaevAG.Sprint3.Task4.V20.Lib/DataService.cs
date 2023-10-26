using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChebulaevAG.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; 
                }

                double y = x / (Math.Cos(x) - x) + 2.5;
                res *= y;
            }

            return Math.Round(res, 3);
        }
    }
}
