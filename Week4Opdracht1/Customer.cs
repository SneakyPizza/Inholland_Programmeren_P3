using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Opdracht1
{
    class Customer
    {
        private int _id;

        public Customer(int id, string firstname, string lastname, string email )
        {
            _id = id;

        }

        public override string ToString()
        {
            return base.ToString();
        }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public string Fullname {  get { return (Firstname + " " + Lastname); } }
        
    }
}
