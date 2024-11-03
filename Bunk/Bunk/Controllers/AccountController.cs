using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bunk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return new List<Account>[] { { 1, new Customer(), new DateOnly(15, 07, 25), 556.7, 15669.0 } };
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public Account Get(int id)
        {
            return new Account { Id = id ,User = new Customer(),DateOpen= new DateOnly(15,07,25),CurrentAccount=556.9,Debit=15669.0 };
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] Account value)
        {
            Account account = new Account();
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
