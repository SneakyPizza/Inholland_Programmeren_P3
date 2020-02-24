using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht3
{
    class CardGame
    {
        private DeckOfCards _deck;

        public CardGame(DeckOfCards d)
        {
            Deck = d;
        }

        public DeckOfCards Deck { get => _deck; set => _deck = value; }
    }
}
