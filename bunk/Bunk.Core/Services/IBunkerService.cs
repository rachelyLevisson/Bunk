using Bunk.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.Services
{
    public interface IBunkerService
    {
        List<Bunker> GetAll();

        Bunker? GetById(int id);

        Bunker Add(Bunker bunker);

        Bunker Update(Bunker bunker);

        void Delete(int id);
    }
}
