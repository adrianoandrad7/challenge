using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hello.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HelloController : ControllerBase
    {
        public HelloController(){}

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello World!");
        }

    }
}