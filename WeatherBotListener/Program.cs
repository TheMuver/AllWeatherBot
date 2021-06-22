using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using WeatherBotLib;

namespace WeatherBotListener
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WeatherBot bot = new WeatherBot(GetToken("telegram.token"), GetToken("yandex.token"));
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
