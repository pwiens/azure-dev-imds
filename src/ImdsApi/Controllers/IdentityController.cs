using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ImdsApi.Controllers
{
    [Route("metadata/[controller]")]
    [ApiController]
    [ApiVersion("2018-02-01")]
    public class IdentityController : ControllerBase
    {
        // GET metadata/identity/oauth2/token
        [HttpGet("oauth2/token")]
        public IActionResult GetToken([FromQuery]string resource)
        {
            return Ok();
        }
    }
}
