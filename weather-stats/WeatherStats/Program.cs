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
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Client client = new Client();
            await client.RetrieveJSON();

            WeatherCollection weatherCollection = JsonConvert.DeserializeObject<WeatherCollection>(client.RawJSONResponse);

            FileWriter fileWriter = new FileWriter(weatherCollection);
            
            string filePath = "";

            if (args.Length == 1)
            {
                filePath = args[0];
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("Please enter path for the output file: ");
                filePath = Console.ReadLine();
            } else
            {
                Console.WriteLine("Incorrect number of arguments.");
            }

            try
            {
                fileWriter.WriteOutputToFile(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Path");
                Console.WriteLine(e);
            }
        }
    }
}
