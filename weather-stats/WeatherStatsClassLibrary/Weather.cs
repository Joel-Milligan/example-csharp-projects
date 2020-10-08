using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStatsClassLibrary
{
    class Weather
    {
        private int sort_order;
        private DateTime local_date_time_full;
        //private int apparent_t; // What?
        private int air_temp;
        //private int dewpt; // What?
        //private int press; // Pressure
        //private int press_qnh;
        //private int press_msl;
        //private string rain_trace;
        //private int rel_hum;
        //private string wind_dir;

        public int Sort_order { get => sort_order; set => sort_order = value; }
        public DateTime Local_date_time_full { get => local_date_time_full; set => local_date_time_full = value; }
        public int Air_temp { get => air_temp; set => air_temp = value; }
    }
}
