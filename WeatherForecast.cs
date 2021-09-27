using System;

namespace FruitServer
{
    public class WeatherForecast
    {
        /// <summary>
        /// Date of forecast
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
