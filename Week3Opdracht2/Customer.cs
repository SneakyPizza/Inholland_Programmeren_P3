using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Opdracht2
{
    class Customer
    {
        private string _name;
        private DateTime _birth;
        private DateTime _signupdate;

        public Customer(string name, DateTime birth)
        {
            _name = name;
            _signupdate = DateTime.Now;

            if (birth <= (DateTime.Now.AddYears(-8)) && birth <= (DateTime.Now.AddYears(120)))
            {
                _birth = birth;
            }
            else
            {
                throw new ArgumentException("Incorrect birthdate", "Birthdate");
            }
        }

        public string Name { get => _name; set { if (value != null && value.Length > 1) { _name = value; } } }
        public DateTime Birth { get => _birth; }
        public DateTime Signupdate { get => _signupdate; }
        public int Age { get => (DateTime.Today.Year - Birth.Year); }
        public bool DiscountPrivilege
        {
            get

            {
                return

                      ((DateTime.Today.Year - Signupdate.Year) > 5);

            }
        }
    }
}
