using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture16
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

    }

    internal class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public int ZIP { get; set; }

    }

}
