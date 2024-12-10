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
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public List<Account> GetAll()
        {
            return _accountRepository.GetList();
        }
    }
}
