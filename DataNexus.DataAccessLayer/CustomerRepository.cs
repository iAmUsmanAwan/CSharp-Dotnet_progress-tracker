using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNexus.BusinessObjects;

namespace DataNexus.DataAccessLayer
{
    public class CustomerRepository
    {
        public void add()
        {
            Console.WriteLine("CustomerRepository.add() called");
        }

        public void Add(Customer customer)
        {
            //throw new NotImplementedException();
            this.add();
        }
    }
}
