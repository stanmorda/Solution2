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
            if (RecordHolder.Max == null || forecast.TemperatureC >= RecordHolder.Max.TemperatureC)
            {
                RecordHolder.Max = forecast;
            }
            if (RecordHolder.Min == null || forecast.TemperatureC <= RecordHolder.Min.TemperatureC)
            {
                RecordHolder.Min = forecast;
            }
        }
        
        return list;
    }


    [HttpGet]
    [Route("max")]
    public ObjectResult Max()
    {
        if (RecordHolder.Max == null)
        {
            return BadRequest("Max is null");
        }
        
        return Ok(RecordHolder.Max);
    }
    
    [HttpGet]
    [Route("min")]
    public ObjectResult Min()
    {
        if (RecordHolder.Min == null)
        {
            return BadRequest("Min is null");
        }
        
        return Ok(RecordHolder.Min);
    }
    
    

}