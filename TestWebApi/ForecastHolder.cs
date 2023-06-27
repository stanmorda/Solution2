using WebApiModel;

namespace TestWebApi;

public class ForecastHolder
{
    public static WeatherForecast? Min { get; set; }
    public static WeatherForecast? Max { get; set; }
    
    public static List<WeatherForecast> History { get; set; }

    static ForecastHolder()
    {
        History = new List<WeatherForecast>();
    }

    public static void AddForecast(WeatherForecast forecast)
    {
        History.Add(forecast);
    }
}