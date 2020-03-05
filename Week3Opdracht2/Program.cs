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
            //Customer test1 = new Customer("bob", (DateTime.Now.AddYears(10)));
            Customer test2 = new Customer("bt", (DateTime.Now.AddYears(-10)));
            PrintCustomer(test2);
            Console.ReadKey();
        }

        private void PrintCustomer(Customer c)
        {
            Console.WriteLine("{0}\n Date of Birth: {1}, \n Age: {2}, \n date of registration: {3}, \n discount: {4}.", c.Name, c.Birth.ToString(), c.Age.ToString(), c.Signupdate.ToString(), c.DiscountPrivilege.ToString());
        }
    }
}
