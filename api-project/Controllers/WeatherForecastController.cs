using System;
using System.Collections.Generic;
using api_proyect.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace api_proyect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("{id?}")]
        public IEnumerable<WeatherForecast> Obtener(int id = -1)
        {
            if(id > -1)
            {
                return id > Data.Instance.numbers.Count
                    ? new List<WeatherForecast>()
                    : new List<WeatherForecast>() { Data.Instance.weatherForecasts[id] };
            }
            
            return Data.Instance.weatherForecasts;
        }

        [HttpPost]
        public WeatherForecast Agregar([FromBody]WeatherForecast weatherForecast)
        {
            Data.Instance.weatherForecasts.Add(weatherForecast);
            return weatherForecast;
        }
    }
}
