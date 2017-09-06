using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public abstract class OnlineBookStore
    {
        public void ProcessTransaction()
        {
            AddBooksToCart();
            ConfirmPurchedBooks();
            SelectShippingMethod();
            VerifyShippingAddress();
            ShippingBook();
            ConfirmDownload();
            DownloadingEbook();
            DeliveringBook();

            if (BankApproves())
            {
                AuthenticatingPayment();
            }            
        }

        void AddBooksToCart()
        {
            Console.WriteLine("Adding books to the shopping cart...");
        }

        void ConfirmPurchedBooks()
        {
            Console.WriteLine("Confirming puchased books...");
        }
        
        //Is only applicable when the paperback option has been selected
        public virtual void SelectShippingMethod() { }

        public virtual void VerifyShippingAddress()
        {
        }
        public abstract void AuthenticatingPayment();
        public void BillingProcess()
        {
            Console.WriteLine("Encrypting billing information...");
        }

        public virtual bool BankApproves()
        {
            return true;
        }

        public virtual void ShippingBook() { }

        public virtual void ConfirmDownload() { }
        public virtual void DownloadingEbook() { }

        public virtual void DeliveringBook() { }



    }
}
