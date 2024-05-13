namespace WeatherAPI.Shared.Models
{
    public class WeatherData
    {
        public string? Name { get; set; }
        public MainData Main { get; set; }
        public WeatherInfo[] Weather { get; set; }
    }

    public class MainData
    {
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public int Humidity { get; set; }
    }

    public class WeatherInfo
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
