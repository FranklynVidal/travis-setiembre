﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ProjectTest.API.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Initial Home Get");
            return $"Demo Travis - Net Core 5.0 Running | FRANKLYN VIDAL... {_configuration["Company:Name"]} - {_configuration["Company:Author"]}";
        }
    }
}
