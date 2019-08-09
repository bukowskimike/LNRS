using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountAPI.Models;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountContext _context;

        public AccountController(AccountContext context)
        {
            _context = context;
        }

        // GET api/account
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/account/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/account
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
