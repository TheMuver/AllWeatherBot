using System;
using System.Threading.Tasks;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;

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
            var command = message.Text.Replace("/", "").ToLower();
            Console.WriteLine("Команда: " + command);

            string answer;
            ReplyKeyboardMarkup keyboardMarkup = null;
            ReplyKeyboardRemove keyboardRemove = new ReplyKeyboardRemove();
            switch (command)
            {
                case "start":
                    answer = "Привет! Я бот, дающий тебе информацию о погоде!";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: keyboardRemove);
                    break;
                case "help":
                    answer = "Список доступных команд: \n 1. /weather - выводит информацию о погоде";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: keyboardRemove);
                    break;
                case "ping":
                    answer = "pong";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: keyboardRemove);
                    break;
                case "weather":
                    //answer = await ConfigureWeatherAnswerAsync();
                    answer = "12";
                    keyboardMarkup = new ReplyKeyboardMarkup();
                    var list = new List<KeyboardButton>();
                    list.Add(new KeyboardButton("Test"));
                    keyboardMarkup.Keyboard = new List<IEnumerable<KeyboardButton>>();
                    keyboardMarkup.Keyboard = keyboardMarkup.Keyboard.Append(list);
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: keyboardMarkup);
                    break;
                default:
                    answer = "Неизвестная команда";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: keyboardRemove);
                    break;
            }
        }

        private async Task<string> ConfigureWeatherAnswerAsync()
        {
            var weather = await _repository.GetWeatherAsync();
            var answer =    $"Информация о погоде ({weather.NowDt.Add(new TimeSpan(3, 0, 0))}): \n" +
                            $" Погода сегодня: \n" + 
                            $"  {weather.Fact.Temp}°C (ощущается как {weather.Fact.FeelsLike}°C) \n" +
                            $" Погода завтра: \n" + 
                            $"  {weather.Forecasts[1].Parts.Day.TempAvg}°C";
            return answer;
        }

        private void foo(int x, int y = 4) {

        }
    }
}