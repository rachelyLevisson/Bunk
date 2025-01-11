namespace Bunk
{
    public interface IDataContext
    {
        public List<Customer> Customers { get; set; }
        public List<Bunker> Bunkers { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
