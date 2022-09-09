using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string Get(int id)
        {
            return "Hello from int Get" + id;
        }

        [Route("{id:minlength(5):maxlength(10)}")]
        public string Get1(string id)
        {
            return "Hello from string Get1" + id;
        }
    }
}
