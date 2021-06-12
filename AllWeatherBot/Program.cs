using System;
using System.IO;
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
            string token = "";
            string tokenPath = "token";
            try
            {
                token = await System.IO.File.ReadAllTextAsync(tokenPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("Problem with token file:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
            }

            WeatherBot bot = new WeatherBot(token);
            Task listening = Task.Run(bot.ListenAsync);
            while (!listening.IsCanceled || !listening.IsCompleted)
            {
                Console.ReadLine();
            }
        }
    }

    class WeatherBot
    {
        TelegramBotClient _client;

        public WeatherBot(string token)
        {
            _client = new TelegramBotClient(token);
            Console.WriteLine("Bot has started successfully");
        }

        public async Task ListenAsync()
        {
            try
            {
                int offset = 0;
                while (true)
                {
                    Update[] updates = await _client.GetUpdatesAsync(offset);
                    foreach (var update in updates)
                    {
                        var message = update.Message;
                        if (message.Type == MessageType.Text)
                        {
                            Task.Run(() => HandleMessage(message));
                        }
                        offset = update.Id + 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public async void HandleMessage(Message message)
        {
            var command = message.Text.Replace("/", "");
            Console.WriteLine(command);
            string answer;
            switch (command) {
                case "start":
                    answer = "Hello!"; 
                    break;
                case "ping":
                    answer = "pong";
                    break;
                default:
                    answer = "Unknown command";
                    break;
            }
            
            await _client.SendTextMessageAsync(message.Chat.Id, answer);
        }
    }
}
