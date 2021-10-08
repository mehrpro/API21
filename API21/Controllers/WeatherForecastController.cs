using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.IServices;

namespace API21.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _loggerManager;

        public WeatherForecastController(ILoggerManager loggerManager)
        {
            _loggerManager = loggerManager;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            _loggerManager.LofInfo("Get Value");
            return new string[] { "Value1", "Value2" };
        }
    }
}
