using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace injectapi.Controllers
{
    [ApiController]
    [Route("exfil/[action]")]
    public class ExfilController : ControllerBase
    {
        [HttpGet("{input}")]
        public void Get([FromRoute] string input)
        {
            Console.WriteLine("API CALLED...");

            Console.WriteLine($"Exfil: {input}");
            var re = Request;
            var headers = re.Headers;

            if (re.HttpContext.Connection.RemoteIpAddress != null)
                Console.WriteLine($"Request from: {re.HttpContext.Connection.RemoteIpAddress}");

            Console.WriteLine("OUTPUT ABOVE ^^");
        }
    }
}
