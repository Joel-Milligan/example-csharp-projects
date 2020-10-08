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
