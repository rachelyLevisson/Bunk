using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bunk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunkerController : ControllerBase
    {

        private readonly IDataContext _context;

        public BunkerController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/<BunkerController>
        [HttpGet]
        public IEnumerable<Bunker> Get()
        {
            return _context.Bunkers;
        }

        // GET api/<BunkerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var bunker = _context.Bunkers.Find(b => b.Id == id);
            if(bunker is null)
                return NotFound();
            return Ok(bunker);
        }

        // POST api/<BunkerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BunkerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BunkerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
