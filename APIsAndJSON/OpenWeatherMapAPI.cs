using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void OpenWeatherMap() 
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var client = new HttpClient();
            Console.WriteLine("What's the zipcode?");
            var zip = Console.ReadLine();
            var apiKey = JObject.Parse(File.ReadAllText("appsettings.json")).GetValue("API Key").ToString(); 
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}&units=imperial";
            var weatherOBJ = client.GetStringAsync(weatherURL).Result;
            JObject response = JObject.Parse(weatherOBJ);

            Console.WriteLine($"It is currently {response["main"]["temp"]} degrees Fahrenheit in the {zip} area code.");
        }
    }
}
