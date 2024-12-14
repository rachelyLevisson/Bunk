using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public List<Account> AccountsList { get; set; }
        public List<Bunker> BunkersList { get; set; }
        //public DateOnly BornDate { get; set; }
    }
}
