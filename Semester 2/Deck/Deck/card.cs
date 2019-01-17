using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class card
    {
        public string suit = "";
        public string face = "";
        public card(string suit,string face)
        {
            this.suit = suit;
            this.face = face;
        }

        public void print()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~\n" + face + "of" + suit + "\n~~~~~~~~~~~~~~~~~~");
        }
    }
}
