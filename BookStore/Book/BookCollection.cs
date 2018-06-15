using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public abstract class BookCollection: IEnumerable<BookCollection>
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public bool Ebook { get; set;}

        public virtual void Add(BookCollection _BookCollection)
        {
            throw new NotSupportedException();
        } 

        public virtual void Remove(BookCollection _BookCollection)
        {
            throw new NotSupportedException();
        }

        public virtual BookCollection GetBook(int index)
        {
            throw new NotSupportedException();
        }

        public virtual void PrintBook()
        {
            throw new NotSupportedException();
        }

        public abstract IEnumerator<BookCollection> CreateIterator();

        public IEnumerator<BookCollection> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
} 
