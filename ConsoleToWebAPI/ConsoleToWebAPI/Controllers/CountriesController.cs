using ConsoleToWebAPI.Models;
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
    [BindProperties]
    public class CountriesController : ControllerBase
    {
        public CountryModel Country { get; set; }

        //[HttpPost("{id}")]
        //public IActionResult AddCountry([FromRoute] int id, [FromHeader] string Developer, [FromHeader] string Course)
        //{
        //    return Ok($"Name = {Developer}");
        //}

        [HttpPost("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok(countries);
        }

        [HttpPost("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name = "Id")] CountryModel country)
        {
            return Ok(country);
        }
    }
}
