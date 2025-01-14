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
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(CustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get()
        {
            var customers = _customerService.GetList();
            var listDTO = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
            return Ok(listDTO);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var customers = _customerService.GetById(id);
            var customerDTO = _mapper.Map<CustomerDTO>(customers);

            return Ok(customerDTO);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
            var newCustomer = _customerService.Add(customer);
            return Ok(newCustomer);
        }


        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            var updatedCustomer = _customerService.Update(customer);
            return Ok(updatedCustomer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _customerService.Delete(id);
            return Ok();
        }
    }
}
