using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht3
{
    public class DeckOfCards
    {

        private List<PlayingCard> _playingCards = new List<PlayingCard>(52);

        public DeckOfCards()
        {
            InitCards(_playingCards);
        }


        private void InitCards(List<PlayingCard> deck)
        {
            string[] values = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k" };

            foreach (string s in values)
            {
                PlayingCard p1 = new PlayingCard(CardSuit.Clubs, s);
                PlayingCard p2 = new PlayingCard(CardSuit.Diamonds, s);
                PlayingCard p3 = new PlayingCard(CardSuit.Hearts, s);
                PlayingCard p4 = new PlayingCard(CardSuit.Spades, s);

                deck.Add(p1);
                deck.Add(p2);
                deck.Add(p3);
                deck.Add(p4);
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            PlayingCards = PlayingCards.OrderBy(item => rand.Next()).ToList();
        }

        public void PrintList()
        {
            foreach (PlayingCard card in PlayingCards)
            {
                Console.WriteLine(card.ToString());
            }

            //Check size, remove later
            Console.WriteLine(string.Format("amount of cards: {0}", PlayingCards.Count));
        }

        //public PlayingCard[] Deck { get => _deck; set => _deck = value; }
        internal List<PlayingCard> PlayingCards { get => _playingCards; set => _playingCards = value; }

    }
}
