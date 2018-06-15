using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    //check account balance before billing
    public class ValidatePayAmount
    {
        public bool AccountIsValid;

        public bool CheckValidAccount(double AccountBalance)
        {
            if (AccountBalance > 0)
            {
                AccountIsValid = true;
                return AccountIsValid;
            }
            else
            {
                return AccountIsValid = false;
            }
        }
    }

