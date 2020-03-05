using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht1
{
    class Book : BookStoreItem
    {
        private string _author;

        public Book(string name, string author, double price, int count): base(name,price, count)
        {
            _author = author;
        }

        public override void Print()
        {
            Console.WriteLine("[Book] Name: {0}, by {1}, price: {2}, amount: x{3}", this.Name, _author, this.Price.ToString(), this.Count);
        }
        public string Author { get => _author; }
    }
}
