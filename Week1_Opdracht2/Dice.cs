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
        Random rnd = new Random();

        public Dice(Random rand)
        {
            value = rand.Next(1, 6);
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
