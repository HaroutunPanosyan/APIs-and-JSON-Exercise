using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            //for (int quoteTalk = 0; quoteTalk <= 5;  quoteTalk++)
            //{
            //    RonVSKanyeAPI.RonQuote();
            //    Console.WriteLine();
            //    RonVSKanyeAPI.KanyeQuote();
            //    Console.WriteLine();
            //}

            //var OWM = new OpenWeatherMapAPI();
            OpenWeatherMapAPI.OpenWeatherMap();

        }
    }
}
