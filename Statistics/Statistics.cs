using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;

        public StatsComputer CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here
            var result = new StatsComputer();

            if (numbers.Count() == 0)
            {
                result.average = double.NaN;
                result.max = double.NaN;
                result.min = double.NaN;
            }
            else
            {
                result.average = numbers.Average();
                result.max = numbers.Max();
                result.min = numbers.Min();

            }


            return result;
        }
    }



}
