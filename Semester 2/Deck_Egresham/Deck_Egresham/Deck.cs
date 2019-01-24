using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Egresham
{
    class Deck
    {
        List<Card> deck = new List<Card>();
        List<Card> discard = new List<Card>();
        
        public void shuffle()
        {
            deck.Add(new Card("Ace", "Spades"));
            deck.Add(new Card("two", "Spades"));
            deck.Add(new Card("three", "Spades"));
            deck.Add(new Card("four", "Spades"));
            deck.Add(new Card("five", "Spades"));
            deck.Add(new Card("six", "Spades"));
            deck.Add(new Card("seven", "Spades"));
            deck.Add(new Card("eight", "Spades"));
            deck.Add(new Card("nine", "Spades"));
            deck.Add(new Card("ten", "Spades"));
            deck.Add(new Card("jack", "Spades"));
            deck.Add(new Card("queen", "Spades"));
            deck.Add(new Card("king", "Spades"));
            deck.Add(new Card("Ace", "Clubs"));
            deck.Add(new Card("two", "Clubs"));
            deck.Add(new Card("three", "Clubs"));
            deck.Add(new Card("four", "Clubs"));
            deck.Add(new Card("five", "Clubs"));
            deck.Add(new Card("six", "Clubs"));
            deck.Add(new Card("seven", "Clubs"));
            deck.Add(new Card("eight", "Clubs"));
            deck.Add(new Card("nine", "Clubs"));
            deck.Add(new Card("ten", "Clubs"));
            deck.Add(new Card("jack", "Clubs"));
            deck.Add(new Card("queen", "Clubs"));
            deck.Add(new Card("king", "Clubs"));
            deck.Add(new Card("Ace", "Diamonds"));
            deck.Add(new Card("two", "Diamonds"));
            deck.Add(new Card("three", "Diamonds"));
            deck.Add(new Card("four", "Diamonds"));
            deck.Add(new Card("five", "Diamonds"));
            deck.Add(new Card("six", "Diamonds"));
            deck.Add(new Card("seven", "Diamonds"));
            deck.Add(new Card("eight", "Diamonds"));
            deck.Add(new Card("nine", "Diamonds"));
            deck.Add(new Card("ten", "Diamonds"));
            deck.Add(new Card("jack", "Diamonds"));
            deck.Add(new Card("queen", "Diamonds"));
            deck.Add(new Card("king", "Diamonds"));
            deck.Add(new Card("Ace", "Hearts"));
            deck.Add(new Card("two", "Hearts"));
            deck.Add(new Card("three", "Hearts"));
            deck.Add(new Card("four", "Hearts"));
            deck.Add(new Card("five", "Hearts"));
            deck.Add(new Card("six", "Hearts"));
            deck.Add(new Card("seven", "Hearts"));
            deck.Add(new Card("eight", "Hearts"));
            deck.Add(new Card("nine", "Hearts"));
            deck.Add(new Card("ten", "Hearts"));
            deck.Add(new Card("jack", "Hearts"));
            deck.Add(new Card("queen", "Hearts"));
            deck.Add(new Card("King", "Hearts"));

            Random rand = new Random();
            deck = deck.OrderBy(t => rand.Next()).ToList();

            discard.Clear();
        }
        public Card Draw()
        {
            if (deck.Count > 1)
            {
                Card lol = deck[deck.Count - 1];
                deck.RemoveAt(deck.Count - 1);
                return lol;
            }
            else
                return null;
        }
        public void Discard(Card c)
        {
            discard.Add(c);
        }

        public void PrintDeck()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                deck[i].print();
            }
        }
        public void PrintDiscard()
        {
            for (int i = 0; i < discard.Count; i++)
            {
               discard[i].print();
            }
        }
    }
}
