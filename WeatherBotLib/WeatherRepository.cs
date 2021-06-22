using System.Threading.Tasks;

namespace WeatherBotLib
{
    /// <summary>
    /// Репозиторий для получения данных о погоде
    /// </summary>
    public interface WeatherRepository
    {
        Task<Weather> GetWeatherAsync();
    }
}