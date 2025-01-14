using AutoMapper;
using Bunk.Core.DTOs_Model;
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
        private readonly IMapper _mapper;

        public BunkerController(BunkerService bunkerService,IMapper mapper)
        {
            _bunkerService = bunkerService;
            _mapper = mapper;
        }


        // GET: api/<BunkerController>
        [HttpGet]
        public ActionResult<Bunker> Get()
        {
            var bunker = _bunkerService.GetAll();
            var listDTO = _mapper.Map<IEnumerable<BunkerDTO>>(bunker);
            return Ok(listDTO);
        }

        // GET api/<BunkerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var bunker = _bunkerService.GetById(id);
            var bunkerDTO = _mapper.Map<BunkerDTO>(bunker);

            return Ok(bunkerDTO);
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