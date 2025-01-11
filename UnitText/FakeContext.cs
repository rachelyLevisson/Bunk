using Bunk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitText
{
    public class FakeContext: IDataContext
    {
        public List<Customer> Customers { get; set; }
        public List<Bunker> Bunkers { get; set; }
        public List<Account> Accounts { get; set; }

        public FakeContext()
        {
            Customers = new List<Customer>() { new Customer() { Id = 1, Name = "Sara", BornDate = new DateOnly() } };
            Bunkers = new List<Bunker>() { new Bunker() { Id = 1, Name = "Avraham", BornDate = new DateOnly(), Salary = 150, Vetek = 5, WorkHour = 7 } };
            Accounts = new List<Account>() { new Account() { Id = 1, User = new Customer(), DateOpen = new DateOnly(), CurrentAccount = 503.5, Debit = 1005.0 } };
        }
    }
}
