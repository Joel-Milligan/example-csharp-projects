using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WeatherStatsClassLibrary
{
    public class Client
    {
        // TODO: Figure out why readonly
        private readonly HttpClient _httpClient;
        private readonly string url = "http://www.bom.gov.au/fwo/IDW60901/IDW60901.94608.json";
        public string RawJSONResponse { get; set; }

        public Client()
        {
            this._httpClient = new HttpClient();
            
            // TODO: Understand these lines of code
            //_httpClient.DefaultRequestHeaders.Add("User-Agent", "C# Console Program");
            //_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task RetrieveJSON()
        {
            HttpResponseMessage response = await this._httpClient.GetAsync(this.url);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception)
            {
                return;
            }
                

            var jsonString = await response.Content.ReadAsStringAsync();

            Console.WriteLine(jsonString);

            this.RawJSONResponse = jsonString;
        }
    }
}