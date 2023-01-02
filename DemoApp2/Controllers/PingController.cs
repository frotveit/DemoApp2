using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp2.Controllers
{
    [ApiController]
    [Route("Ping")]
    public class PingController : Controller
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Ping")]
        [AllowAnonymous]
        public IActionResult Ping()
        {
            _logger?.LogInformation("Ping");
            return Ok("Pong");
        }
    }
}
