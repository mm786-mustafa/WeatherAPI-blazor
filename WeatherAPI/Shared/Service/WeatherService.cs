using System.Net.Http.Json;
using WeatherAPI.Shared.Models;

namespace WeatherAPI.Shared.Service
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeather(string cityName)
        {
            return await _httpClient.GetFromJsonAsync<WeatherData>("https://api.openweathermap.org/data/2.5/weather?q="+cityName+"&units=metric&appid=f0c42ff3a38a1ff235b42553bb662aab");
        }
    }
}
