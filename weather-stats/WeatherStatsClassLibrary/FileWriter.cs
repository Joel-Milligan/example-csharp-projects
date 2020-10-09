using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStatsClassLibrary
{
    public class FileWriter
    {
        List<string> output { get; set; }

        public FileWriter()
        {
            output = new List<string>();
        }

        public FileWriter(WeatherCollection weather)
        {
            output = new List<string>();
            GenerateOutput(weather);
        }

        public void GenerateOutput(WeatherCollection weather)
        {
            // TODO: Look into string building

            // 72 Hour Averages at the top of the file
            output.Add("AVERAGES FROM THE LAST 72 HOURS");
            output.Add("Air Temperature: " + DataCalculation.AverageAirTemperature(weather).ToString() + " degrees celcius");
            output.Add("Wind Speed: " + DataCalculation.AverageWindSpeed(weather).ToString() + "km/h");
            output.Add("");
            output.Add("Maximum Temperature: " + DataCalculation.ExtremeTemperature(weather, true).ToString() + " degrees celcius");
            output.Add("Minimum Temperature: " + DataCalculation.ExtremeTemperature(weather, false).ToString() + " degrees celcius");
            output.Add("");

            // For each time point list: Air temperature and Rainfall
            foreach (var dataPoint in weather.observations.data)
            {
                output.Add(dataPoint.ToString());
            }
        }

        public void WriteOutputToFile(string path)
        {
            System.IO.File.WriteAllLines(path, this.output);
        }
    }
}
