using Bunk.Core.Entity;
using Bunk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Data.Repositories
{
    public class BunkerRepository : IBunkerRepository
    {
        private readonly DataContext _dataContext;

        public BunkerRepository(DataContext context)
        {
            _dataContext = context;
        }

        public List<Bunker> GetList()
        {
            return _dataContext.Bunkers.ToList();
        }
    }
}
