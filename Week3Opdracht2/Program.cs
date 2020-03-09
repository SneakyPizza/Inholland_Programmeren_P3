using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht2
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
            List<Customer> customers = new List<Customer>();
            try
            {
                Customer test1 = new Customer("bob bips", (DateTime.Now.AddYears(-100)));
                Customer test2 = new Customer("qwer ty", (DateTime.Now.AddYears(-10)));
                //Customer test3 = new Customer("bop", (DateTime.Now.AddDays(-1000)));
                //Customer test4 = new Customer("bip", (DateTime.Now.AddDays(1)));

                Ticket t1 = new Ticket("The Hobbit", 4, new DateTime(2020, 10, 6, 10, 30, 0), 10, 6);
                Ticket t2 = new Ticket("The Bobbit", 5, new DateTime(2020, 11, 7, 10, 30, 0), 12, 16);
                Ticket t3 = new Ticket("The Fobbit", 3, new DateTime(2020, 9, 4, 12, 30, 0), 16, 9);

                Reservation r1 = new Reservation(test1);
                Reservation r2 = new Reservation(test2);
                //Customers
                customers.Add(test1);
                customers.Add(test2);
                PrintCustomer(customers);

                //Tickets
                r1.AddTicket(t1);
                r2.AddTicket(t2);
                r2.AddTicket(t3);
                //PrintTicket(t1);
                //PrintTicket(t2);

                //Reservations
                PrintReservation(r1);
                PrintReservation(r2);
            } catch(Exception e)
            {
                Console.WriteLine("Error occured: {0}",e.Message);
            }

            Console.ReadKey();
        }

        private void PrintCustomer(List<Customer> ca)
        {
            foreach(Customer c in ca)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Creating {0}", c.Name);
                Console.ResetColor();
                Console.WriteLine("{0}: \n Date of Birth: {1}, \n Age: {2}, \n date of registration: {3}, \n discount: {4}. \n", c.Name, c.Birth.ToString(), c.Age.ToString(), c.Signupdate.ToString(), c.DiscountPrivilege.ToString());
            }
        }

        private void PrintTicket(Ticket t)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Creating {0}", t.Name);
            Console.ResetColor();
            Console.WriteLine("Ticket created for {0}, Room: {1}, \n Starting at: {2}, Minimum age: {3}, \n Price: {4}, discount ?: {5} \n", t.Name, t.RoomNum.ToString(), t.Starttime.ToShortTimeString(), t.MinAge.ToString(), t.Price.ToString(), t.Discount);
        }

        private void PrintReservation(Reservation r)
        {
            foreach(Ticket t in r.Tickets)
            {
                PrintTicket(t);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[{0}]total price: {1} \n",r.Customer.Name , r.TotalPrice);
        }
    }
}
