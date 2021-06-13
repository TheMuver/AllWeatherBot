using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace AllWeatherBot
{
    public class WeatherBot
    {
        TelegramBotClient _client = new TelegramBotClient(Program.GetToken("telegram.token"));
        WeatherRepository _repository = new YandexWeatherRepository(Program.GetToken("yandex.token"));

        public WeatherBot()
        {
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