using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Egresham
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck();
            Card mycard = new Card("", "");


            int option;
            do
            {
                Console.WriteLine("Option 1: shuffle");
                Console.WriteLine("Option 2: print Deck");
                Console.WriteLine("Option 3: Draw Card");
                Console.WriteLine("option 4: Discard");
                Console.WriteLine("Option 5: print discard");
                Console.WriteLine("option 6: exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        mydeck.shuffle();
                        break;
                    case 2:
                        mydeck.PrintDeck();
                        break;
                    case 3:
                        mycard = mydeck.Draw();
                        break;
                    case 4:
                        mydeck.Discard(mycard);
                        break;
                    case 5:
                        mydeck.PrintDiscard();
                        break;
                }
            } while (option != 6);
       
            
         



        }
    }
}
