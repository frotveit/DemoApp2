using Microsoft.AspNetCore.Mvc;

namespace DemoApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : Controller
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Ping")]
        public IActionResult Ping()
        {
            return Ok("Pong");
        }
    }
}
