using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht1
{
    class Magazine : Book
    {
        private DateTime _date;

        public Magazine(string name, string author, double price, DateTime date): base(name, author, price)
        {
            _date = date;
        }

        public override void Print()
        {
            //base.Print();
            Console.WriteLine("[Magazine] Name: {0}, by {1}, price: {2}, Date of Release: {3}", Name, Author, Price.ToString(), _date);

        }

        public DateTime Date
        {
            get => _date;
        }
    }
}
