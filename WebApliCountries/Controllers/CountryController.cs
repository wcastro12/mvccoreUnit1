using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApliCountries.Models;

namespace WebApliCountries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly AplicationContext Context;
        public CountryController(AplicationContext context)
        {
            this.Context = context;
        }


        [HttpGet]
        public IEnumerable<Country> Get()
        {
            var result = this.Context.Countries.ToList();
            return result;
        }

        [HttpGet("Id",Name ="CountryCreate")]
        public IActionResult Get(int id)
        {
            var country = this.Context.Countries.ToList().Select(a => a.CountryID = id);

            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        [HttpPost]
        public ActionResult Post( [FromBody] Country country)
        {
            if (ModelState.IsValid)
            {
                this.Context.Countries.Add(country);
                this.Context.SaveChanges();
                return new CreatedAtActionResult("CountryCreate", "Country", new { id = country.CountryID }, country);
            }

            return BadRequest(ModelState);
        }
    }
}