using Bunk.Core.Entity;
using Bunk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Data.Repositories
{
    public class RepositoryManager: IRepositoryManager
    {
        private readonly DataContext _context;
        public ICustomerRepository Customers { get; }
        public IBunkerRepository Bunker { get; }
        public IAccountRepository Account { get; }

        public RepositoryManager(DataContext context, IRepository<Customer> customerRepository, IRepository<Bunker> bunkerRepository , IRepository<Account> accountRepository)
        {
            _context = context;
            Customers = (ICustomerRepository?)customerRepository;
            Bunker = (IBunkerRepository?)bunkerRepository;
            Account = (IAccountRepository?)accountRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
