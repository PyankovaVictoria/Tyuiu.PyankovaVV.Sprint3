using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PyankovaVV.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiSeries = 1;
            while (startValue <= stopValue)
            {
                multiSeries *= Math.Cos(value) + (startValue / 4.0);
                startValue++;
            }
            return Math.Round(multiSeries, 3);
        }
    }
}
