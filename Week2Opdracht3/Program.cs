using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht3
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
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }

        private void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndGame())
            {
                war.NextCard();
            }
            //TO DO: ADD wincondition
        }
    }
}
