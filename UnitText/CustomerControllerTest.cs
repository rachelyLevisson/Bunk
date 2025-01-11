using Bunk;
using Bunk.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitText
{
    public class CustomerControllerTest
    {
        private readonly CustomerController _controller;

        public CustomerControllerTest()
        {
            FakeContext fakeContext = new FakeContext();
             _controller = new CustomerController(fakeContext);
        }


        [Fact]
        public void GetAll_RetrunsListOfCustomer()
        {
           

            
            var result = _controller.Get();

            Assert.IsType<List<Customer>>(result);
        }


        [Fact]
        public void GetById_RetrunsOk()
        {
            var id = 1;

            var result = _controller.Get(id);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_RetrunsNotFound()
        {
            var id = 5;

            var result = _controller.Get(id);

            Assert.IsType<NotFoundResult>(result);
        }
    }
}
