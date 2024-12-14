using Bunk.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();

        Customer? GetById(int id);

        Customer Add(Customer customer);

        Customer Update(Customer customer);

        void Delete(int id);
    }
}
