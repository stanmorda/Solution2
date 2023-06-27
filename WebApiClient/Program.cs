// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WebApiModel;

var url = "http://localhost:9999/WeatherForecast";
var httpClient = new HttpClient();
var response = await httpClient.GetAsync(url);
if (response.IsSuccessStatusCode)
{
    Console.WriteLine("Got response:");
    var result = await response.Content.ReadAsStringAsync();
    var forecasts = JsonConvert.DeserializeObject<WeatherForecast[]>(result);
    var min = forecasts.Select(x => x.TemperatureC).Min();
    var max = forecasts.Select(x => x.TemperatureC).Max();

    var minFromServer = await httpClient.GetFromJsonAsync<WeatherForecast>("http://localhost:9999/WeatherForecast/min");
    var maxFromServer = await httpClient.GetFromJsonAsync<WeatherForecast>("http://localhost:9999/WeatherForecast/max");

    if (min != minFromServer.TemperatureC || max != maxFromServer.TemperatureC)
    {
        Console.WriteLine("ERROR");
    }
    else
    {    
        Console.WriteLine("Test passed!");
    }
    Console.Read();
}



