using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core.Entity
{
    public class Bunker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BornDate { get; set; }
        public int Vetek { get; set; }
        public double WorkHour { get; set; }
        public double Salary { get; set; }
    }
}
