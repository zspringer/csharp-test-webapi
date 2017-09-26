using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_test_webapi.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        List<Book> Books = new List<Book>() {
            new Book("Moby Dick", "Penguin", 400, "Sdlkskjd333-f"),
            new Book("Fake Book", "Fakers", 700, "Sdlkdddskjd333-j"),
            new Book("Harry Potter", "ZachBooks", 150, "Sdlkskjdsfeee3-z")
        };

        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            // return new string[] { "book1", "book2" };
            return Books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return Books[id];
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
