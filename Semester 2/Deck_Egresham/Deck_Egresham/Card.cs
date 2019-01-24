using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Egresham
{
    class Card
    {
        public string suit = "";
        public string face = "";
        public Card(string suit, string face)
        {
            this.suit = suit;
            this.face = face;

        }
        public void print()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" + suit + " of " + face + "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
