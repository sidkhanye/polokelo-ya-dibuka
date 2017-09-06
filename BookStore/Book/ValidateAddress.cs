using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    //validating customer's address is valid
    public class ValidateAddress
    {
        public bool AddressIsValid;
        public bool CheckValidCustomer(string Address)
        {

            if (!Address.Equals(null))
            {
                AddressIsValid = true;
                return AddressIsValid;
            }
            else
            {
                return AddressIsValid = false;
            }
        }
    }
}
