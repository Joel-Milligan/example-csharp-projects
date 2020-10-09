using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WeatherStatsClassLibrary
{
    public class WeatherDataPoint
    {
        public string local_date_time_full { get; set; }
        public double air_temp { get; set; }
        public int rel_hum { get; set; }
        public string wind_dir { get; set; }
        public int wind_spd_kmh { get; set; }

        public override string ToString()
        {
            return $"Time: { DateTime.ParseExact(this.local_date_time_full, "yyyyMMddHHmmss", CultureInfo.InvariantCulture)}" +
                $"\tAir Temperature: { this.air_temp}" +
                $"\tHumidity: { this.rel_hum}%" +
                $"\tWind Speed (km/h): { this.wind_spd_kmh }" +
                $"\tWind Direction: { this.wind_dir }";
        }
    }
}
