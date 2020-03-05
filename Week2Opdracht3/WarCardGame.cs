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

        public WarCardGame(Player p1, Player p2)
        {
            _deck = Deck;

            _p1 = p1;
            _p2 = p2;
        }

        public void StartNewGame()
        {
            _deck.Shuffle();

            _p1.CurrentCards.Clear();
            _p2.CurrentCards.Clear();

            Player curr = _p1;

            foreach (PlayingCard card in _deck.PlayingCards)
            {
                curr.AddCard(card);
                curr = (curr == _p1) ? _p2 : _p1;
            }
        }

        public void NextCard()
        {
            PlayingCard p1pc = (_p1.CurrentCards[0]);
            PlayingCard p2pc = (_p2.CurrentCards[0]);

            Console.WriteLine("[{0}], {1} {2} - [{3}], {4} {5}", _p1.Name, p1pc.Rank, p1pc.Suit, _p2.Name, p2pc.Rank, p2pc.Suit);

            if (RankCalc(p1pc) > RankCalc(p2pc))
            {
                //p1 win
                _p1.AddCard(p2pc);
                Console.WriteLine("{0} got the cards", _p1.Name);
                _p2.CurrentCards.Remove(p2pc);

            } else if( RankCalc(p1pc) == RankCalc(p2pc))
            {
                //Draw
                //_p2.AddCard(p2pc);
                _p2.CurrentCards.RemoveAt(0);
                Console.WriteLine("Draw");
                //_p1.AddCard(p1pc);
                _p1.CurrentCards.RemoveAt(0);
            } else
            {
                //p2 win
                _p2.AddCard(p1pc);
                Console.WriteLine("{0} got the cards", _p2.Name);
                _p1.CurrentCards.Remove(p1pc);
            }

            if (_p1.CurrentCards.Count <= 5 || _p2.CurrentCards.Count <= 5)
            {
                Console.WriteLine("[{0}] has {1} cards left - [{2}] has {3} cards left", _p1.Name, _p1.CurrentCards.Count, _p2.Name, _p2.CurrentCards.Count);
            }
        }

        private int RankCalc(PlayingCard p)
        {
            string[] values = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string pval = p.Rank;

            for(int i = 0; i < values.Length; i++)
            {
                if(pval == values[i])
                {
                    return i;
                }
            }
            return 0;
        }

        public bool EndGame()
        {
           if(_p1.CurrentCards.Count <= 0)
            {
                Console.WriteLine("{0} wins", _p2.Name);
                return true;
            } else if(_p2.CurrentCards.Count <= 0)
            {
                Console.WriteLine("{0} wins", _p1.Name);
                return true;
            }
            return false;
        }

        internal Player P1 { get => _p1; }
        internal Player P2 { get => _p2; }
    }
}
