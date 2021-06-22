using System;
using System.Threading.Tasks;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;

namespace WeatherBotLib
{
    public class WeatherBot
    {
        TelegramBotClient _client;
        WeatherRepository _repository;

        public WeatherBot(string telegramToken, string yandexToken)
        {
            _client = new TelegramBotClient(telegramToken);
            _repository = new YandexWeatherRepository(yandexToken);
            Console.WriteLine("Bot has started successfully");
        }

        public WeatherBot SetWebhook(string url)
        {
            _client.SetWebhookAsync(url).Wait();
            return this;
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
            switch (command)
            {
                case "start":
                    answer = "Привет! Я бот, дающий тебе информацию о погоде! Для продолжения работы можете ознакомится со списком команд /help";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: new ReplyKeyboardRemove());
                    break;
                case "help":
                    answer = "Список доступных команд: \n 1. /weather - выводит информацию о погоде";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: configureKeyboard(new string[] { "/weather" }));
                    break;
                case "ping":
                    answer = "pong";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: new ReplyKeyboardRemove());
                    break;
                case "weather":
                    answer = await ConfigureWeatherAnswerAsync();
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: new ReplyKeyboardRemove());
                    break;
                default:
                    answer = "Неизвестная команда";
                    await _client.SendTextMessageAsync(message.Chat.Id, answer, replyMarkup: new ReplyKeyboardRemove());
                    break;
            }
        }

        private ReplyKeyboardMarkup configureKeyboard(string[] buttons)
        {
            var keyboardMarkup = new ReplyKeyboardMarkup();
            keyboardMarkup.ResizeKeyboard = true;
            // rows
            keyboardMarkup.Keyboard = new List<IEnumerable<KeyboardButton>>();
            // strings
            keyboardMarkup.Keyboard = keyboardMarkup.Keyboard.Append(buttons.Select(s => new KeyboardButton(s)).ToList());
            return keyboardMarkup;
        }

        private async Task<string> ConfigureWeatherAnswerAsync()
        {
            var weather = await _repository.GetWeatherAsync();
            var answer = $"Информация о погоде ({weather.NowDt.Add(new TimeSpan(3, 0, 0))}): \n" +
                            $" Погода сегодня: \n" +
                            $"  {weather.Fact.Temp}°C (ощущается как {weather.Fact.FeelsLike}°C) \n" +
                            $" Погода завтра: \n" +
                            $"  {weather.Forecasts[1].Parts.Day.TempAvg}°C" +
                            $"Яндекс.Погода";
            return answer;
        }

        private void foo(int x, int y = 4)
        {

        }
    }
}