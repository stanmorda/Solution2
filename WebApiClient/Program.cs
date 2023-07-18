// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WebApiModel;

var url = "http://localhost:9999/WeatherForecast";
var httpClient = new HttpClient();


var forecast = new WeatherForecast()
{
    TemperatureC = 100,
    Date = DateOnly.FromDateTime(DateTime.Now),
    Summary = "TestSummary"
};

var content = new StringContent(JsonConvert.SerializeObject(forecast), Encoding.UTF8, "application/json");

var response = await httpClient.PostAsync($"{url}/save", content);
if (response.IsSuccessStatusCode)
{
    var history = await httpClient.GetFromJsonAsync<WeatherForecast[]>($"{url}/history");
    if (history.Any(x => x.TemperatureC == forecast.TemperatureC && x.Date == forecast.Date))
    {
        Console.WriteLine("Test passed");
    }
}
Console.Read();

async Task TestGet()
{
    var response = await httpClient.GetAsync(url);
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Got response:");
        var result = await response.Content.ReadAsStringAsync();
        var forecasts = JsonConvert.DeserializeObject<WeatherForecast[]>(result);
        var min = forecasts.Select(x => x.TemperatureC).Min();
        var max = forecasts.Select(x => x.TemperatureC).Max();

        var minFromServer =
            await httpClient.GetFromJsonAsync<WeatherForecast>("http://localhost:9999/WeatherForecast/min");
        var maxFromServer =
            await httpClient.GetFromJsonAsync<WeatherForecast>("http://localhost:9999/WeatherForecast/max");

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
}

//await TestGet();



