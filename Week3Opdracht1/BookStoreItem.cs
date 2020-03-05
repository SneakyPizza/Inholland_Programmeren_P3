using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht1
{
    abstract class BookStoreItem
    {
        public BookStoreItem(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public string Name { get; private set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public abstract void Print();
    }
}
