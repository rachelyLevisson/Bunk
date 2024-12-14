using Bunk.Core.Entity;
using Bunk.Core.Repositories;
using Bunk.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetList()
        {
            return _customerRepository.GetAll();
        }

        public Customer? GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public Customer Add(Customer Customer)
        {
            return _customerRepository.Add(Customer);
        }

        public Customer Update(Customer Customer)
        {
            return _customerRepository.Update(Customer);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}