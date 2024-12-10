using Bunk.Core.Entity;
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

        public List<Customer> GetList()
        {
            return _dataContext.Customers;
        }
    }
}
