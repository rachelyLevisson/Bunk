namespace Bunk
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
