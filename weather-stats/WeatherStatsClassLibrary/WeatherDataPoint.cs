﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WeatherStatsClassLibrary
{
    public class WeatherDataPoint
    {
        public int sort_order { get; set; }
        public int wmo { get; set; }
        public string name { get; set; }
        public string history_product { get; set; }
        public string local_date_time { get; set; }
        public string local_date_time_full { get; set; }
        public string aifstime_utc { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double apparent_t { get; set; }
        public string cloud { get; set; }
        public object cloud_base_m { get; set; }
        public object cloud_oktas { get; set; }
        public object cloud_type_id { get; set; }
        public string cloud_type { get; set; }
        public double delta_t { get; set; }
        public int gust_kmh { get; set; }
        public int gust_kt { get; set; }
        public double air_temp { get; set; }
        public double dewpt { get; set; }
        public double press { get; set; }
        public double press_qnh { get; set; }
        public double press_msl { get; set; }
        public string press_tend { get; set; }
        public string rain_trace { get; set; }
        public int rel_hum { get; set; }
        public string sea_state { get; set; }
        public string swell_dir_worded { get; set; }
        public object swell_height { get; set; }
        public object swell_period { get; set; }
        public string vis_km { get; set; }
        public string weather { get; set; }
        public string wind_dir { get; set; }
        public int wind_spd_kmh { get; set; }
        public int wind_spd_kt { get; set; }

        public override string ToString()
        {
            return $"Time: { DateTime.ParseExact(this.local_date_time_full, "yyyyMMddHHmmss", CultureInfo.InvariantCulture)}\tAir Temperature: { this.air_temp}";
        }
    }
}
