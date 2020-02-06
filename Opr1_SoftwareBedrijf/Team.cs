using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opr1_SoftwareBedrijf
{
    public class Team
    {
        private List<Programmer> pteam;
        public Team(Programmer pro1, Programmer pro2, Programmer pro3, Programmer pro4)
        {
            pteam = new List<Programmer>();
            AddProgrammer(pro1);
            AddProgrammer(pro2);
            AddProgrammer(pro3);
            AddProgrammer(pro4);
        }

        

        public void PrintAllTeamMems(List<Programmer> pList)
        {
            foreach(Programmer p in pList)
            {
                p.Print();
            }
        }

        public List<Programmer> Pteam
        {
            get { return pteam; }
        } 

        public void AddProgrammer(Programmer p)
        {
            pteam.Add(p);
        }
    }
}
