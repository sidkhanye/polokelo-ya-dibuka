using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookItem: BookCollection
    {
        //overriding of methods inherited from the BookCollection abstract class. 
        public override IEnumerator<BookCollection> CreateIterator()
        {
            return null;
        }
        
        public override void PrintBook()
        {          

            if (Ebook == true)
            {
              Price -= 30;
            }
            else
            {
                Price += 30;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Book Price : {0:c}", Price);
            Console.WriteLine("Book Description: {0}", Description);
            Console.WriteLine("Book Title: {0}", Title);
            Console.WriteLine("Book Author: {0}", Author);
            Console.WriteLine("Book Author: {0}", Year); 
           
        }
    }
}
