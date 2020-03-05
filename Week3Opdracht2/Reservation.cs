using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht2
{
    class Reservation
    {
        private List<Ticket> _tickets = new List<Ticket>();
        private Customer _customer;

        public Reservation(Customer customer)
        {
            _customer = customer;
        }

        public void AddTicket(Ticket t)
        {
            _tickets.Add(t);
        }

        internal List<Ticket> Tickets { get => _tickets; }
        public decimal TotalPrice {  get
            {
                decimal p = 0;
                foreach(Ticket t in Tickets)
                {
                    if (t.Discount)
                    {
                        t.Price -= ((t.Price / 100) * 5);
                    }
                    p += t.Price;
                }

                if (_customer.DiscountPrivilege)
                {
                    p -= ((p / 100 * 10));
                }
                return p;
            } }

        internal Customer Customer { get => _customer;}
    }
}
