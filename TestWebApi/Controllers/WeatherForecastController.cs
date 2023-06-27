using Microsoft.AspNetCore.Mvc;
using WebApiModel;

namespace TestWebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class WeatherForecastController : ControllerBase
{

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

  
    public WeatherForecastController()
    {
       
    }

    [HttpPost]
    [Route("save")]
    public void SaveForecast(WeatherForecast forecast)
    {
        ForecastHolder.AddForecast(forecast);
    }

    [HttpGet]
    [Route("history")]
    public OkObjectResult GetHistory()
    {
        return Ok(ForecastHolder.History);
    }
    
    [HttpGet]
    [Route("summary")]
    public string GetSummary(int index, string comment)
    {
        return $"{Summaries[index]}-{comment}";
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public WeatherForecast[] Get()
    {
        var list = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        foreach (var forecast in list)
        {
            if (ForecastHolder.Max == null || forecast.TemperatureC >= ForecastHolder.Max.TemperatureC)
            {
                ForecastHolder.Max = forecast;
            }
            if (ForecastHolder.Min == null || forecast.TemperatureC <= ForecastHolder.Min.TemperatureC)
            {
                ForecastHolder.Min = forecast;
            }
        }
        
        return list;
    }


    [HttpGet]
    [Route("max")]
    public ObjectResult Max()
    {
        if (ForecastHolder.Max == null)
        {
            return BadRequest("Max is null");
        }
        
        return Ok(ForecastHolder.Max);
    }
    
    [HttpGet]
    [Route("min")]
    public ObjectResult Min()
    {
        if (ForecastHolder.Min == null)
        {
            return BadRequest("Min is null");
        }
        
        return Ok(ForecastHolder.Min);
    }
    
    

}