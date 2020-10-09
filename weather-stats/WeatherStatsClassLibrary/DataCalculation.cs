using System;
using System.Collections.Generic;
using System.Globalization;
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

            return Math.Round(sumTemp / weatherCollection.observations.data.Count, 1);
        }

        public static string ExtremeTemperature(WeatherCollection weatherCollection, bool max)
        {
            double extremeTemp;
            DateTime dateTime = new DateTime();

            if (max)
            {
                extremeTemp = double.MinValue;
            }
            else
            {
                extremeTemp = double.MaxValue;
            }

            foreach (var dataPoint in weatherCollection.observations.data)
            {
                // Check if max/min depending on the max parameter.
                if ((dataPoint.air_temp > extremeTemp && max) ||
                    (dataPoint.air_temp < extremeTemp && !max))
                {
                    extremeTemp = dataPoint.air_temp;
                    dateTime = DateTime.ParseExact(dataPoint.local_date_time_full, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                }
            }

            return extremeTemp.ToString() + " degrees celcius\tat " + dateTime.ToString();
        }

        public static double AverageHumidity(WeatherCollection weatherCollection)
        {
            double sumHum = 0;

            foreach (var dataPoint in weatherCollection.observations.data)
            {
                sumHum += dataPoint.rel_hum;
            }

            return Math.Round(sumHum / weatherCollection.observations.data.Count, 1);
        }

        public static double AverageWindSpeed(WeatherCollection weatherCollection)
        {
            double sumSpeed = 0;

            foreach (var dataPoint in weatherCollection.observations.data)
            {
                sumSpeed += dataPoint.wind_spd_kmh;
            }

            return Math.Round(sumSpeed / weatherCollection.observations.data.Count, 1);
        }
    }
}
