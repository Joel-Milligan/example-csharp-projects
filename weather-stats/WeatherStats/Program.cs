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
        static void Main(string[] args) // TOOD: Take args for where to place the output file.
        {
            Client client = new Client();
            client.RetrieveJSON();

            Console.WriteLine(client.RawJSONResponse);

            var weatherCollection = JsonConvert.DeserializeObject<dynamic>(client.RawJSONResponse);

            Console.WriteLine(weatherCollection.data[0].air_temp);
            Console.ReadLine();
        }
    }
}
