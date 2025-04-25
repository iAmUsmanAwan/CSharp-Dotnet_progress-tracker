using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNexus.BusinessObjects
{
    public class CustomerAddress
    {
        public int CustomerID { get; set; }  // Primary Key, Foreign Key
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        // Navigation Property
        public Customer Customer { get; set; }
    }
}
