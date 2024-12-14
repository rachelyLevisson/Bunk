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

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get()
        {
            var customers = _customerService.GetList();
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var custmers = _customerService.GetById(id);
            return Ok(custmers);
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
