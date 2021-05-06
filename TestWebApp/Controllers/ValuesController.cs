using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            _logger.LogInformation($"GET api/values");
            using var random = System.Security.Cryptography.RandomNumberGenerator.Create();
            var bytes = new byte[4];
            for (var i = 0; i < 10; i++)
            {
                random.GetBytes(bytes);
                yield return BitConverter.ToInt32(bytes) % 10000;
            }
        }
    }
}
