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
        public Customer User { get; set; }
        public DateOnly DateOpen { get; set; }
        public double CurrentAccount { get; set; }
        public double Debit { get; set; }
    }
}
