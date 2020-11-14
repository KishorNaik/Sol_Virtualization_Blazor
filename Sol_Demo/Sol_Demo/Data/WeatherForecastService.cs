using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        private readonly List<WeatherForecast> forecasts = new List<WeatherForecast>();

        public async Task<WeatherForecast[]> GetForecastAsync(int daysFromNow, int count)
        {
            await Task.Delay(Math.Min(count * 20, 2000));

            var rng = new Random();

            while (forecasts.Count < daysFromNow + count)
            {
                forecasts.Add(new WeatherForecast
                {
                    Date = DateTime.Today.AddDays(forecasts.Count),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                });
            }

            return forecasts.Skip(daysFromNow).Take(count).ToArray();
        }
    }
}