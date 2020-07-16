using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleTestAPIDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        [Route("get-sample")]
        public ActionResult GetAction()
        {
            return Ok("This is a GET method");
        }

        [HttpPost]
        [Route("post-sample")]
        public ActionResult PostAction()
        {
            return Ok("This is a POST method");
        }
    }
}
