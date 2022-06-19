﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marketing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingController : ControllerBase
    {
        // GET: api/<MarketingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MarketingController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { Marketing =  "marketing" });
        }

        // POST api/<MarketingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MarketingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MarketingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
