using System;
using System.Net.Http;

namespace AllWeatherBot
{
    /// <summary>
    /// Получает, отдаёт, обрабатывает информацию о погоде, прешедшую с API яндекса
    /// </summary>
    public class YandexWeatherRepository : WeatherRepository
    {
        private Weather _weather;
        private string _token;

        public YandexWeatherRepository(string token) {
            _token = token;
        }

        public Weather GetWeather()
        {

        }
    }
}