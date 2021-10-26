using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class StatsAlerter
    {
        private double maxThreshold;
        private IAlerter[] alerters;

        public StatsAlerter(double maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }




        public void checkAndAlert(List<double> list)
        {

            foreach (var number in list)
            {
                if (number > this.maxThreshold)
                {
                    foreach (var alert in this.alerters)
                    {
                        alert.SendAlert();
                    }
                }
            }
        }
    }
}
