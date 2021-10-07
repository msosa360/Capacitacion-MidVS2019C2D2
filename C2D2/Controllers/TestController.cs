using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C2D2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        [HttpGet("traerfechaactual")]
        public DateTime TraerFechaActual()
        {
            return DateTime.Now;
        }

        [HttpGet("traerhoraactual")]
        public string TraerHoraActual()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
