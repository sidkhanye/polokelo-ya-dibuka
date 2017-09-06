using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    //authenticating customer 
    public class ValidateCustomer
    {
        public bool CustomerIsValid;
        
        public bool CheckValidCustomer(string CustomerName)
        {
            var customers = new List<string> { "John", "Jack", "Mary", "Tom" };

            if (customers.Contains(CustomerName)) 
            {
                CustomerIsValid = true;
                return CustomerIsValid;
            }
            else
            {
                return false;
            }
        }
    }
}
