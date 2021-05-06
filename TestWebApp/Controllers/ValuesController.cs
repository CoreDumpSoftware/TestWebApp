using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get() => new[] { "A", "B", "C" };
    }
}
