using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{   
    public class Books : BookCollection
    {
        private List<BookCollection> _BookCollection = new List<BookCollection>();

        public override void Add(BookCollection Collection)
        {
            _BookCollection.Add(Collection);
        }

        public override void Remove(BookCollection _BookCollection)
        {
            _BookCollection.Remove(_BookCollection);
        }

        public override BookCollection GetBook(int index)
        {
            return _BookCollection[index];
        }
        public override void PrintBook()
        {           
            Console.WriteLine("Publisher: {0}", Publisher);

            foreach (BookCollection CurrentBook in _BookCollection)
            {
                CurrentBook.PrintBook();
            }
                
        }
        public override IEnumerator<BookCollection> CreateIterator()
        {
            return _BookCollection.GetEnumerator();
        }
    }
}
