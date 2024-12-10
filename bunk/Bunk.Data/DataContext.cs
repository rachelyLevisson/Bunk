using Bunk.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Data
{
    public class DataContext
    {
        public List<Account> Accounts { get; set; }
        public List<Bunker> Bunkers { get; set; }
        public List<Customer> Customers { get; set; }

        public DataContext()
        {
            Customers = new List<Customer>();
            Customers.Add(new Customer { Id = 1, Name = "Sara" });
            Accounts = new List<Account>();
            Accounts.Add(new Account { Id = 1, User = new Customer(), CurrentAccount = 2.5, Debit = 50.8, DateOpen = new DateOnly() });
            Bunkers = new List<Bunker>();
            Bunkers.Add(new Bunker { Id = 1, Name = "Markantil", Salary = 50000, Vetek = 7, WorkHour = 6, BornDate = new DateOnly() });

        }
    }
}
