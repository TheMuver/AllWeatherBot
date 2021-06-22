using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WeatherBotLib
{
    /// <summary>
    /// Получает, отдаёт, обрабатывает информацию о погоде, прешедшую с API яндекса
    /// </summary>
    public class YandexWeatherRepository : WeatherRepository
    {
        private Weather _weather;
        private string _token;

        public YandexWeatherRepository(string token)
        {
            _token = token;
        }

        public async Task<Weather> GetWeatherAsync()
        {
            var time = DateTimeOffset.Now.ToUnixTimeSeconds();
            if (_weather == null)
            {
                _weather = await GetWeatherFromServerAsync();
            }
            else if (time - _weather.Now > 150) // 2.5 минут = 150 сек
            {
                _weather = await GetWeatherFromServerAsync();
            }
            return _weather;
        }

        private async Task<Weather> GetWeatherFromServerAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.weather.yandex.ru/v2/forecast?lat=55.755819&lon=37.617644&lang=ru_RU");
            request.Headers.Add("X-Yandex-API-Key", _token);
            var response = (await client.SendAsync(request)).EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();
            stream.Position = 0;
            using (var sr = new StreamReader(stream))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    return new JsonSerializer().Deserialize<Weather>(jr);
                }
            }
        }

        private async Task<Weather> GetWeatherFromFileAsync() {
            var stream = File.OpenRead("json");
            using (var sr = new StreamReader(stream))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    return new JsonSerializer().Deserialize<Weather>(jr);
                }
            }
        }
    }
}