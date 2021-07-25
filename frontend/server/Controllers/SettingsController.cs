using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace server.Controllers
{
    [ApiController]
    [Route("settings")]
    public class SettingsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new List<string> { "AAAAAAAAAAAAAAAAAA" };
        }
    }
}
