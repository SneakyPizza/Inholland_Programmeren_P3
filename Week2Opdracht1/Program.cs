using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        private void Start()
        {

            BookStore bs = new BookStore();
            Book b1 = new Book("Boek 1", "Bob", 15.50);
            Book b2 = new Book("Boek 2", "Beb", 16.50);
            Book b3 = new Book("Boek 3", "Bab", 17.50);
            Book b4 = new Book("Boek 4", "Bub", 18.25);

            Magazine m1 = new Magazine("Spiderman", "Stan lee", 10.50, DateTime.MinValue);
            Magazine m2 = new Magazine("Ik ken geen stripboeken", "Baapie", 4.20, DateTime.MaxValue);
            bs.AddBook(m1);
            bs.AddBook(m2);

            bs.AddBook(b1);
            bs.AddBook(b2);
            bs.AddBook(b3);
            bs.AddBook(b4);
            bs.PrintBooks(bs.Books);
            bs.PrintPrice(bs.CalcTotalPrice(bs.Books));
            Console.ReadKey();
        }
    }
}
