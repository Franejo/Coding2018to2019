using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egresham_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an int and initialize to 0.
            int opt;
            // make another int call it randomint 
            int randomInt;
            // make a random
            Random rand = new Random();

            // initialize int#2 to the random.
            randomInt = rand.Next(1000);
            // make one last int call it i and initialize it to 0
            int i = 1;

            // do 
            do
            {
                // ask the user for an input of a number, 0 if they want to exit the program
                Console.WriteLine("Please input a number between 1 and 1000. input 0 if you want to exit the program:  ");
                // initialize the answer to the int.
                opt = int.Parse(Console.ReadLine());

                //  if int > randomint
                // say "lower
                //
                if (opt > randomInt)
                {
                    Console.WriteLine("go lower");

                }
                // if int < randomint
                //say higher
                //
                if (opt < randomInt && opt > 0)
                {
                    Console.WriteLine("Go Higher");

                }
                //if int = randomint
                //say congratulations
                // break out of the do
                //
                if (opt == randomInt)
                {
                    Console.WriteLine("Congratulations you got it");
                    Console.ReadKey();
                    break;
                }


                // add 1 to i every repeat
                i++;
                // end of do
            }
            //while int doesnt equal -1
            while (opt != 0);
            // state how many tries it took by using i.
            if (opt == 0)
            {
                Console.WriteLine("You are a quitter. and you dissapoint me");
                Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("It took you: " + i + " tries");
                Console.ReadLine();
            }
        }
    }
}
