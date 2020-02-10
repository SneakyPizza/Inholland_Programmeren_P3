﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht1
{
    class Book
    {
        private string _name;
        private string _author;
        private double _price;
        public Book(string name, string author, double price)
        {
            _name = name;
            _author = author;
            _price = price;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, by {1}, price: {2}", _name, _author, _price.ToString());
        }
    }
}
