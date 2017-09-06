using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookStoreFacade
    {
        ValidateAddress _validateAddress = new ValidateAddress();
        ValidateCustomer _validateCustomer = new ValidateCustomer();
        ValidatePayAmount _validatePayment = new ValidatePayAmount();

        public bool PaymentAccepted = false;
        public bool ValidateTransaction(string CustomerName = "", string CusomerAddress = "", double AccountBalance)
        {

            if (_validateCustomer.CheckValidCustomer(CustomerName) && _validatePayment.CheckValidAccount(AccountBalance) && _validateAddress.CheckValidCustomer(CusomerAddress))
            {
                PaymentAccepted = true;
            }
            else
            {
                PaymentAccepted = false;
            }
            return PaymentAccepted;
        }
    }
}
