using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tool.Controllers
{
    [Route("Api/Tool")]
    [ApiController]
    public class ToolController : Controller
    {
        /// <summary>
        /// Uploade1
        /// </summary>
        /// <returns></returns>
        [Route("Uploade1")]
        [HttpGet]
        public  IActionResult Uploade1()
        {

            return Ok();

        }
        /// <summary>
        /// Uploade2
        /// </summary>
        /// <returns></returns>
        [Route("Uploade2")]
        [HttpGet]
        public IActionResult Uploade2()
        {

            return Ok();

        }
    }
}
