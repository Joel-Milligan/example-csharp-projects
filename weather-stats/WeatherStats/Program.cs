using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using WeatherStatsClassLibrary;

namespace WeatherStats
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args) // TOOD: Take args for where to place the output file.
        {
            Client client = new Client();
            await client.RetrieveJSON();

            WeatherCollection weatherCollection = JsonConvert.DeserializeObject<WeatherCollection>(client.RawJSONResponse);

            string filePath = @"C:\Users\Public\Test.txt";

            FileWriter fileWriter = new FileWriter(weatherCollection);
            fileWriter.WriteOutputToFile(filePath);
        }
    }
}
