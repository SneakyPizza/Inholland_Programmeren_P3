﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht1
{
    class BookStore
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book b)
        {
            _books.Add(b);
        }

        public void PrintBooks(List<Book> blist)
        {
            foreach(Book bo in blist)
            {
                bo.Print();
            }
        }

        public List<Book> Books { get => _books; }
    }
}
