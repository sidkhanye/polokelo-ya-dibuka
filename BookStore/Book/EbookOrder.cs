using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class EbookOrder : OnlineBookStore
    {
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
            var responses = new List<string> { "approved", "declined" };

            int index = ran.Next(responses.Count);
            string response = responses[index];
            responses.RemoveAt(index);

            if (response.ToLower().Equals("declined"))
            {
                return "declined";
            }

            return response;
        }

        public override void ConfirmDownload()
        {
            Console.WriteLine("Confirming and scanning download...");
        }
        public override void DownloadingEbook()
        {
            Console.WriteLine("Congratulations, your ebook has been successfully downloaded.");
        }
    }
}
