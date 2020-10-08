using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStatsClassLibrary
{
    public class DataCalculation
    {
        public static double AverageAirTemperature(WeatherCollection weatherCollection)
        {
            double sumTemp = 0;

            foreach (var dataPoint in weatherCollection.observations.data)
            {
                sumTemp += dataPoint.air_temp;
            }

            return sumTemp / weatherCollection.observations.data.Count;
        }
    }
}
