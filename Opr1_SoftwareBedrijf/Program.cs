using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opr1_SoftwareBedrijf
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
            Programmer pro1 = new Programmer("Bob", Specialty.HTML);
            Programmer pro2 = new Programmer("Beb", Specialty.Java);
            Programmer pro3 = new Programmer("Bab", Specialty.PHP);
            Programmer pro4 = new Programmer("Bub");

            Team t = new Team(pro1, pro2, pro3, pro4);

            t.PrintAllTeamMems(t.Pteam);
            Console.ReadKey();
        }
    }
}
