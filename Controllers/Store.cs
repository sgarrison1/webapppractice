using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Store : ControllerBase
    {
        // GET: api/Store
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "Class" };
        }

        // GET: api/Store
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Store
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Store
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Store
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
