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
        public Team()
        {
            pteam = new List<Programmer>();
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
