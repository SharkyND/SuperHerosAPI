using Microsoft.AspNetCore.Mvc;

namespace SuperheroAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet("GetToSayHiSir")]
    public PersonData GetTest()
    {
        PersonData Person = new PersonData();
        Person.Name="Test";
        Person.LastName="Test";
        Person.Role="Test";
        
        return Person;
    }

    [HttpPost("byId")]
    public async Task<ActionResult<PersonData>> PostPerson(PersonData personData)
    {   
        
        return Ok();
    }
}