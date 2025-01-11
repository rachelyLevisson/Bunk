using CsvHelper;
using System.Globalization;

namespace Bunk
{
    public class ExcelContext: IDataContext
    {
        public List<Customer> Customers { get; set; }
        public List<Bunker> Bunkers { get; set; }
        public List<Account> Accounts { get; set; }

        public ExcelContext()
        {
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Customers = csv.GetRecords<Customer>().ToList();
            }

            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Bunkers = csv.GetRecords<Bunker>().ToList();
            }

            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Accounts = csv.GetRecords<Account>().ToList();
            }
        }
    }
}
