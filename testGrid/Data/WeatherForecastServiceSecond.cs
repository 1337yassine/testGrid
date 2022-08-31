namespace testGrid.Data
{
    public class WeatherForecastServiceSecond
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


        public Task<List<WeatherForecast>> GetForecastAsyncs(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 100).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index).Date.ToShortDateString(),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList());
        }
    }


}