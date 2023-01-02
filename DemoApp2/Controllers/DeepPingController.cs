using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace DemoApp2.Controllers
{
    [ApiController]
    [Route("DeepPing")]
    public class DeepPingController : Controller
    {
        private readonly IDeepPingService _service;

        public DeepPingController(IDeepPingService service)
        {
            _service = service;
        }

        [HttpGet(Name = "DeepPing")]
        public IActionResult DeepPing()
        {
            return Ok(_service.DeepPing());
        }
    }
}
