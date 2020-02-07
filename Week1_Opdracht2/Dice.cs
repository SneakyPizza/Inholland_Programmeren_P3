using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Dice
    {
        public int value;
        Random rnd;

        public Dice(Random rand)
        {
            rnd = rand;
            Throwdice(this);
        }

        public void Throwdice(Dice d)
        {
            value = rnd.Next(1, 6);
        }

        public void ShowValue()
        {
            Console.Write(value + " ");
        }
    }
}
