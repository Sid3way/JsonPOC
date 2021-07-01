using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FWJsonController : ControllerBase
    {
        [HttpPut]
        public void Set(WeatherForecast wf)
        {
        }

        [HttpGet]
        public WeatherForecast Get()
        {
            return new WeatherForecast(42, "summary", "WeirdString", "BullshitString");
            //return new WeatherForecast();
        }
    }
}
