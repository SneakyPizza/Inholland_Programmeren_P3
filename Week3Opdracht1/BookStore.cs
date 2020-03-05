using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht1
{
    class BookStore
    {
        private List<BookStoreItem> _books = new List<BookStoreItem>();
        public void AddBook(BookStoreItem b)
        {
            _books.Add(b);
        }

        public void PrintBooks(List<BookStoreItem> blist)
        {
            foreach(BookStoreItem bo in blist)
            {
                bo.Print();
            }
        }

        public void PrintPrice(double price)
        {
            Console.WriteLine("Total sales price: {0}", price);
        }

        public double CalcTotalPrice(List<BookStoreItem> blist)
        {
            double p = 0;
            foreach(BookStoreItem b in blist)
            {
                p += (b.Price * b.Count);
            }
            return p;
        }

        public List<BookStoreItem> Books { get => _books; }
    }
}
