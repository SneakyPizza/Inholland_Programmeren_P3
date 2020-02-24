using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht3
{
    class WarCardGame : CardGame
    {
        private DeckOfCards _deck;

        private Player _p1;
        private Player _p2;

        public WarCardGame(DeckOfCards d, Player p1, Player p2):base(d)
        {
            _deck = d;

            _p1 = p1;
            _p2 = p2;
        }

        public void StartNewGame()
        {
            _deck.Shuffle();

        }

        public void NextCard()
        {

        }
        public bool EndGame()
        {
           if(_p1.CurrentCards.Count <= 0 || _p2.CurrentCards.Count <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
