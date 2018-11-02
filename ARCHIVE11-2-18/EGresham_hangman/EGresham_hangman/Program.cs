using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGresham_hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            char guess;
            
            string currentWord;
            string[] words = {"double", "excited", "square","ultra", "elfin", "volleyball", "glorious","cycle","belief","pinch","poised","curve","school","plant","giraffe", "consist","approval","scorch", "grin", "gruesome", "file", "adjoining","encourage","irritate","quarrelsome","numberless"};
            List<char> guesses = new List<char>();
            Random rand = new Random();
            int length;

            Console.Write("welcome to hangman. Guess the word or the man gets hung.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            int correctGuess = 0;
            int incorrectguess = 6;

            int i;
            i = rand.Next(0, 25);
            currentWord = words[i];
            length = currentWord.Length;
            int u = 1;

            do
            {


                Console.WriteLine();
                for (int j = 0; j < currentWord.Length; j++)
                {



                    if (guesses.Contains(currentWord[j]))
                    {
                        Console.Write(currentWord[j]);


                    }
                    else
                    {
                        Console.Write("_");

                    }


                }
                Console.WriteLine();
                Console.WriteLine("Please make a one character guess for what letter you think might be in the word: ");
                guess = char.Parse(Console.ReadLine());
                guesses.Add(guess);
                if (!currentWord.Contains(guess))
                {
                    --incorrectguess;

                }
                Console.WriteLine("You have guessed: ");
                for (int h = 0; h < u; h++)
                {
                    Console.Write(guesses[h] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Your number of incorrect guesses left is: " + incorrectguess);
                u++;
                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (guess == currentWord[j])
                    {
                        correctGuess++;
                        if (correctGuess == currentWord.Length)
                        {
                            Console.WriteLine("You won! It took you " + (u - 1) + " tries to get it right!");
                            Console.ReadKey();
                            return;
                        }
                    }


                }



            } while (incorrectguess > 0);
            
           

            
           
                Console.WriteLine("You lost! the word was: " + currentWord);
                Console.ReadKey();
                return;
          


        }
    }
}
