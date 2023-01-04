using Microsoft.AspNetCore.Mvc;
using Service;

namespace Api.Controllers
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
        public async Task<IActionResult> DeepPing()
        {
            return Ok(await _service.DeepPing());
        }
    }
}
