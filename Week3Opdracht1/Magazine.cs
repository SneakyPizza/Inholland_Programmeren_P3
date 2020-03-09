using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht1
{
    class Magazine : BookStoreItem
    {
        private DateTime _date;

        public Magazine(string name, double price, DateTime date, int count): base(name, price, count)
        {
            _date = date;
        }

        public override void Print()
        {
            //base.Print();
            Console.WriteLine("[Magazine] Name: {0}, price: {1}, Date of Release: {2}, amount: x{3}", this.Name, this.Price.ToString(), _date.ToShortDateString(), this.Count);
        }
        public DateTime Date
        {
            get => _date;
        }
    }
}
