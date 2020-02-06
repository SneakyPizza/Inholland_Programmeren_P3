using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opr1_SoftwareBedrijf
{
    public class Programmer
    {
        private string _name;
        private Specialty _specialty;

        public Programmer(string n, Specialty s)
        {
            _name = n;
            _specialty = s;
        }

        public Programmer(string name)
        {
            _name = name;
            _specialty = Specialty.Unkown;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, Specialty: {1}", this._name, this._specialty);
        }

        public string Name
        {
            get{ return _name; }
        }

        public Specialty Specialty
        {
            get { return _specialty; }
        }
        
    }
}
