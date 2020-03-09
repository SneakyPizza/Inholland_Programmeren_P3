using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Opdracht1
{
    class Book
    {
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set;  }
    }
}
