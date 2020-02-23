using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Opdracht2
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
            DeckOfCards deck = new DeckOfCards();
            deck.PrintList();
            deck.Shuffle();
            deck.PrintList();
            Console.ReadKey();
        }
    }
}
