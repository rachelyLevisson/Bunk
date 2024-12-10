using Bunk.Core.Entity;
using Bunk.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bunk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunkerController : ControllerBase
    {
        private readonly BunkerService _bunkerService;

        public BunkerController(BunkerService bunkerService)
        {
            _bunkerService = bunkerService;
        }


        // GET: api/<BunkerController>
        [HttpGet]
        public IEnumerable<Bunker> Get()
        {
            return _bunkerService.GetAll();
        }

        // GET api/<BunkerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
