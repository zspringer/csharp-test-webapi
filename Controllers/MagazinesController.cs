using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_test_webapi.Controllers
{
    [Route("api/[controller]")]
    public class MagazinesController : Controller
    {
        List<Magazine> Magazines = new List<Magazine>() {
            new Magazine("Time", "Time", 4100, "ItsTime!", 232),
            new Magazine("Time", "Time", 4100, "ItsTime!", 232),
            new Magazine("Boys Life", "BoyScouts", 100, "ItsTime!", 232)
            
        };

        // GET api/values
        [HttpGet]
        //IEnumerable is saying that it will iterate over a list
        public IEnumerable<Magazine> Get()
        {
            // return new string[] { "book1", "book2" };
            return Magazines;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Magazine Get(int id)
        {
            return Magazines[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
