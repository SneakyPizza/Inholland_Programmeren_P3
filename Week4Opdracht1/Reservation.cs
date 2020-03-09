using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Opdracht1
{
    class Reservation
    {
        private int _id;

        public Reservation(int id, Book book, Customer customer)
        {
            _id = id;
            Book = book;
            Customer = customer;
            ReservationDate = DateTime.Now;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Reservation nr. {0} created for {1}, containing {2}. \n Creationdate: {3}.", ID.ToString(), Customer.Fullname, Book.Title, ReservationDate.ToShortDateString());
        }

        public int ID { get => _id; }
        public Book Book { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime ReservationDate { get; private set; }
    }
}
