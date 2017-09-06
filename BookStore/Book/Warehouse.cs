using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Warehouse: BookCollection
    {
        private BookCollection PublishedBooks;

        public Warehouse(BookCollection PublishedBooks)
        {
            this.PublishedBooks = PublishedBooks;
        }

        public override IEnumerator<BookCollection> CreateIterator()
        {
            return null;
        }

        public void PrintCollection()
        {
            PublishedBooks.PrintBook();
        }
    }
}
