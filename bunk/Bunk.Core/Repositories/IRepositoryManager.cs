using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.Repositories
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customers { get; }
        IBunkerRepository Bunker { get; }
        IAccountRepository Account { get; }

        void Save();
    }
}
