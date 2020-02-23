using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht3
{
    class PlayingCard
    {
        private string _rank;
        private CardSuit _suit;


        public PlayingCard(CardSuit suit, string rank)
        {
            _rank = rank;
            _suit = suit;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", _rank, _suit);
        }
    }
}
