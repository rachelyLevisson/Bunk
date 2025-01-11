using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bunk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IDataContext _context;


        public AccountController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _context.Accounts;
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var account = _context.Accounts.Find(a => a.Id == id);
            if (account is null)
            {
                return NotFound();
            }
            return Ok(account);
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
