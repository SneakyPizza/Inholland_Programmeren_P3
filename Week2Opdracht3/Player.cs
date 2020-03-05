using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht3
{
    class Player
    {
        private string _name;
        private List<PlayingCard> _currentCards;

        public Player(string name)
        {
            Name = name;
            _currentCards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard card)
        {
            _currentCards.Add(card);
        }

        public PlayingCard GetNextCard(List<PlayingCard> cards)
        {
            PlayingCard pc = cards[0];
            cards.Remove(pc);
            return pc;
        }

        public string Name { get => _name; set => _name = value; }
        internal List<PlayingCard> CurrentCards { get => _currentCards; set => _currentCards = value; }
    }
}
