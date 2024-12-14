using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.Entity
{
    public class Account
    {
        public int Id { get; set; } 
        public double CurrentAccount { get; set; }
        public double Debit { get; set; }

        //one - to-many
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
      
    }
}
