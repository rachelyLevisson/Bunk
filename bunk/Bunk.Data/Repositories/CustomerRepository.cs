using Bunk.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Bunk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;

        public CustomerRepository(DataContext context)
        {
            _dataContext = context;
        }

        public List<Customer> GetAll()
        {
            return _dataContext.Customers.Include(c => c.AccountsList.ToList()).ToList();
        }

        public Customer? GetById(int id)
        {
            return _dataContext.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Customer Add(Customer customer)
        {
            _dataContext.Customers.Add(customer);
            return customer;
        }

        public Customer Update(Customer customer)
        {
            var existingCustomer = GetById(customer.Id);
            if (existingCustomer is null)
            {
                throw new Exception("User not found");
            }
            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            return existingCustomer;
        }


        public void Delete(int id)
        {
            var existingCustomer = GetById(id);
            if (existingCustomer is not null)
            {
                _dataContext.Customers.Remove(existingCustomer);
            }
        }
    }
}
