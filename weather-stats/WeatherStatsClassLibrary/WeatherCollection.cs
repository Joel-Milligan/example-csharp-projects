using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using WeatherStatsClassLibrary;

namespace WeatherStatsClassLibrary
{
    public class WeatherCollection
    {
        public Observations observations { get; set; }
    }

    public class Observations
    {
        public List<WeatherHeader> header { get; set; }

        public List<WeatherDataPoint> data { get; set; }
    }
}
