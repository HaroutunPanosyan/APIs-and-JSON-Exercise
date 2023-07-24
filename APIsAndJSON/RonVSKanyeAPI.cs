
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void RonQuote()
        {
            // Create new HTTP Client (allows use of communication with HTTP Client)
            var client = new HttpClient();
            // URL (Endpoint)
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            // GET request
            var ronResponse = client.GetStringAsync(ronURL).Result;
            // Parse [Array] / Object           
            var ronQuote = JArray.Parse(ronResponse);
            //Write Quote to console
            Console.WriteLine($"Ron: {ronQuote[0]}");
        }
        public static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");
        }
    }
}
