namespace AllWeatherBot
{
    /// <summary>
    /// Репозиторий для получения данных о погоде
    /// </summary>
    public interface WeatherRepository
    {
        Weather GetWeather();
    }
}