using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Opdracht1
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
            Book b = new Book(1, "Testboek", "Billy");
            Customer c = new Customer(2, "Bob", "Johnson","email@mail.nl");
            Reservation s = new Reservation(1, b, c);
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
