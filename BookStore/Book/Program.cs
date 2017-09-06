using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            BookStoreFacade _BookStoreFacade = new BookStoreFacade();

            //Transaction proceeds provided the Customer name registered in the system, address is provided and balance is sufficient
            if (_BookStoreFacade.ValidateTransaction("John", "123 University Way, Summerstrand, Port Elizabeth", 1200))
            {
                Console.WriteLine("\nAccount is ready for transation...\n");
            }
            else
            {
                //If customer balance if insufficient transaction process is terminated
                Console.WriteLine("\nYou do not have sufficient funds on your account.");
                Console.ReadKey();
                
            }


            BookCollection Bloomsbury = new Books { Publisher = "\t Books Published by Bloomsbury\n" };
            BookCollection Penguin = new Books { Publisher = "\tBooks Published by Penguin Publishers\n" };
            BookCollection Scribner = new Books { Publisher = "\tBooks Published by Scribner \n" };

            BookCollection EntireCollection = new Books { Publisher = "\t****List of ordered books by publisher****\n" };

            EntireCollection.Add(Bloomsbury);

            //All the books published under Bloomsbury
            Bloomsbury.Add(new BookItem
            {
                Title = "Harry Potter and the Philosher's Stone",
                Description = "A fantasy novel based on the life of a boy who goes to a school of wizardry",
                Author = "J.K Rowling",
                Price = 143.95,
                Ebook = false,
                Year = 1997
            });

            Bloomsbury.Add(new BookItem
            {
                Title = "Hotel",
                Description = "A fictional novel about a hotel in New Orleans",
                Author = "Arthur Hailey",
                Price = 179.00,
                Ebook = true,
                Year = 1965
            });


            //books published under Penguin
            EntireCollection.Add(Penguin);

            Penguin.Add(new BookItem
            {
                Title = "The Picture of Dorian Gray",
                Description = "A classic philosphical novel.",
                Author = "Mary Shelley",
                Price = 115.00,
                Ebook = true,
                Year = 1818
            });

            Penguin.Add(new BookItem
            {
                Title = "Frankeinstein",
                Description = "A novel about Victor Frankeinstein.",
                Author = "Joseph Whitaker",
                Year = 1868,
                Price = 140.00,
                Ebook = false
            });

            //bookds published under Scribner 
            EntireCollection.Add(Scribner);

            Scribner.Add(new BookItem
            {
                Title = "The Shinning",
                Description = "A horror novel about a caretaker named Jack Torrance.",
                Author = "Stephen King",
                Year = 1977,
                Price = 190.00,
                Ebook = true
            });
            Scribner.Add(new BookItem
            {
                Title = "The Dark Tower V",
                Description = "The fifth novel on the dark tower series.",
                Author = "Stephen King",
                Year = 2003,
                Price = 210.00,
                Ebook = false
            });

            var publishinghouse = new Warehouse(EntireCollection);
            publishinghouse.PrintCollection();


            //Actual transaction processes start, will  only execute after customer details have been validated 
            Console.WriteLine("\n\n \t*************************************Paperback order*************************************");
            OnlineBookStore hardcopy = new PaperBackOrder();
            hardcopy.ProcessTransaction();

            Console.WriteLine("\n \t*************************************Ebook order *************************************");
            OnlineBookStore softcopy = new EbookOrder();
            softcopy.ProcessTransaction();

            Console.ReadKey();
        }
    }
}
