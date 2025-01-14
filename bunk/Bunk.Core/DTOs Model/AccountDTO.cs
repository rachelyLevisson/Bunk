using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.DTOs_Model
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public double CurrentAccount { get; set; }
        public double Debit { get; set; }

        //one - to-many
        public int CustomerId { get; set; }
    }
}
