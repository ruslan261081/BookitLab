using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookitLab
{
    class Program
    {
        static void Main(string[] args)
        {

            using (BookitLabEntities bookitLab = new BookitLabEntities())
            {
                List<Customer> customers = bookitLab.Customers.ToList();

            }
        }
    }
}
