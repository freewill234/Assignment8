using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameReturn : ControllerBase
    {
     

        private readonly ILogger<NameReturn> _logger;

        public NameReturn(ILogger<NameReturn> logger)
        {
            _logger = logger;
        }

       

        }
        [HttpGet]
        public IActionResult Get()
        {
        return { "name":"Evan Kelley"}
        }
    }
}
