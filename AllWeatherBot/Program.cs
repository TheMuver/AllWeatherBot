using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace AllWeatherBot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // var repos = new YandexWeatherRepository(GetToken("yandex.token"));
            // var weather = await repos.GetWeatherAsync();
            // Console.WriteLine(weather.Fact.Temp + " " + weather.Info.TzInfo.Name);
            WeatherBot bot = new WeatherBot();
            Task listening = Task.Run(bot.ListenAsync);
            while (!listening.IsCompleted)
            {
                Console.ReadLine();
            }
        }

        public static string GetToken(string tokenPath) {
            return System.IO.File.ReadAllText(tokenPath);
        }
    }
}
