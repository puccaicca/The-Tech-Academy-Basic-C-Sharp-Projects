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
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            ////game.Play();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;


            //stuct
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //Lambdaxpressions?
            //Deck deck = new Deck();

            ////int count = deck.Cards.Count(x => x.Face == Face.Ace);

            ////List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            //int sum = numberList.Where(x => x > 20).Sum(); 
            //Console.WriteLine(sum);
            
           
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{ 
            //Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //////Console.WriteLine("Times suffled: {0}", timesShuffled); // the {0} inputs the value from timesShuffled
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
