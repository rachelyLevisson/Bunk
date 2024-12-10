using Bunk.Core.Entity;
using Bunk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _dataContext;

        public AccountRepository(DataContext context)
        {
            _dataContext = context;
        }

        public List<Account> GetList()
        {
            return _dataContext.Accounts;
        }
    }
}
