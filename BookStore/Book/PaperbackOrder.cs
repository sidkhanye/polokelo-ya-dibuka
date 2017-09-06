using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class PaperBackOrder : OnlineBookStore
    {

        public override void SelectShippingMethod()
        {
            string SelectedShipMethod = GetShippingMethod();
            
            Console.WriteLine("Book will be shipped using: {0}", SelectedShipMethod);
        }

        public string GetShippingMethod()
        {
            string shippingMethod = string.Empty;
            int selection = 0;
            Console.WriteLine("Select shipping method:\n 1.UPS First-Class | 2.FedEx Overnight | 3.UPS Two-Days | 4.UPS Priority | 5.UPS First-Class International");

            selection = int.Parse(Console.ReadLine());
            try
            {
                switch (selection)
                {
                    case 1:
                        shippingMethod = "UPS First-Class";
                        Console.WriteLine(shippingMethod);
                        break;
                        

                    case 2:
                        shippingMethod = "FedEx Overnight";
                        Console.WriteLine(shippingMethod);
                        break;

                    case 3:
                        shippingMethod = "UPS Two-Days";
                        Console.WriteLine(shippingMethod);
                        break;

                    case 4:
                        shippingMethod = "UPS First-Class";
                        Console.WriteLine(shippingMethod);                       
                       break;

                    case 5:
                        shippingMethod = "UPS Priority";
                        Console.WriteLine(shippingMethod);
                        break;

                    default:
                         shippingMethod = "Invalid selection";
                        Console.WriteLine(shippingMethod);
                        break;

                }             
            }
            catch 
            {
                Console.WriteLine("Invalid input.");
            }
            return shippingMethod;
        }

        public override bool BankApproves()
        {
            string response = GetBankResponse();

            if (response.Equals("approved"))
            {
                return true;
            }
            else 
            {
                return false;
            }
        } 
        public override void AuthenticatingPayment()
        {
            Console.WriteLine("Purchase processed successfully.");
        }       
        public string GetBankResponse()
        {
            Random ran = new Random();
            var responses = new List<string>{ "approved","declined" };

            int index = ran.Next(responses.Count);
            string response = responses[index];
            responses.RemoveAt(index);

            if (response.ToLower().Equals("declined"))
            {
                return "declined";
            }

            return response;
        }

        public override void VerifyShippingAddress()
        {
            Console.WriteLine("Shipping address confirmed.");
        }

        public override void ShippingBook()
        {
            Console.WriteLine("Shipping book to your location...");
        }
        public override void DeliveringBook()
        {
            Console.WriteLine("Book has been delivered to your location.");
        }
    }
}
