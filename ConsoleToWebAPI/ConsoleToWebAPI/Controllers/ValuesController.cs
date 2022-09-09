using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("{id?}")]
        public string Get(int id)
        {
            return "Hello from Get" + id;
        }

        [Route("~/Get1")]
        [Route("~/Get23")]
        public string Get1()
        {
            return "Hello from Get1";
        }

        public string newAll(int id)
        {
            return "Hello from newAll" + id;
        }
    }
}
