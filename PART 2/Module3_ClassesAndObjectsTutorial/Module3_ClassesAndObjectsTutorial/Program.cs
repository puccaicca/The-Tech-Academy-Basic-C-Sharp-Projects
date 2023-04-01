using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ClassesAndObjectsTutorial // TwentyOne Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck); //first shuffle
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times suffled: {0}", timesShuffled); // the {0} inputs the value from timesShuffled
            Console.ReadLine();
        }

      

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
