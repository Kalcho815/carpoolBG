using carpoolBG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UserManager<CarpoolUser> userManager;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, UserManager<CarpoolUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public async Task<IdentityResult> Post()
        {
            var testUser = new CarpoolUser { UserName = "FirstTest"
                , Email = "FirstEmailTest"
                , FirstName = "Ivan"
                , LastName = "Ivanov"
                , Sex = Models.Enums.Sex.Male
                , UserType = Models.Enums.UserType.Passenger};
            
            var result = await userManager.CreateAsync(testUser, "Ttestuser123!");

            return result;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> forecasts = new List<WeatherForecast>();

            forecasts.Add(new WeatherForecast { Date= DateOnly.FromDateTime(DateTime.Now), Summary = "test", TemperatureC = 32 });

            return forecasts;

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}