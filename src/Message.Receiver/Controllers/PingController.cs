using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Message.Receiver.Controllers { 

    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public string Get()
        {
            return "Pong!";
        }

        [HttpGet(Name = "getversion")]
        public string GetVersion()
        {
            return Environment.GetEnvironmentVariable("VERSION");
        }
    }
}