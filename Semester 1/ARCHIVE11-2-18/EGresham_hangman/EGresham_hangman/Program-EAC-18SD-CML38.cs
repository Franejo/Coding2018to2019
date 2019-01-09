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
            char oml;
            string correctWrd;
            char guess;
            int opt;  
            string currentWord;
            string[] words = {"double", "excited", "square","ultra", "elfin", "volley", "glorious","cycle","belief","pinch","poised","curve","school","plant","giraffe", "consist","approval","scorch", "grin", "gruesome", "file", "adjoining","encourage","gunk","quarrel","number"};
            List<char> guesses = new List<char>();
            List<char> Correctchar = new List<char>();
            Random rand = new Random();
            int length;

            Console.Write("welcome to hangman. Guess the word or the man gets hung.");
            Console.WriteLine(" Please press any key other t if you would like to continue to the hanging platform, and 2 if you would like to exit the gallows: ");
            opt = int.Parse(Console.ReadLine());

            int q = 0;
            int i;
            i = rand.Next(0, 25);
            currentWord = words[i];
            length = currentWord.Length - 1;
            int correctGuess = 0;
            int k = 10;
            bool wack = true;
            do
            {
                k--;



                
                Console.WriteLine();
                for (int j = 0; j < currentWord.Length; j++)
                {

                    if (guesses.Contains(currentWord[j]))
                    {

                        Console.Write(currentWord[j]);
                        correctGuess++;
                    }
                    else if (!guesses.Contains(currentWord[j]))
                    {

                        Console.Write("_");

                    }

                }
                
                Console.WriteLine();
                Console.WriteLine(" Please make a one character guess for what letter you think might be in the word: ");
                guess = char.Parse(Console.ReadLine());
                guesses.Add(guess);
                q++;
                Console.WriteLine("You have " + k + " incorrect guesses remaining.");
                Console.Write("You have guessed: ");
                for (int m = 0; m < q; m++)
                {

                    Console.Write(guesses[m]);

                }

                Console.WriteLine();
                if(correctGuess == currentWord.Length)
                {
                    wack = false;
                }

            }
            while (wack = true or k > 0);
            if(k == 0)
            {
                Console.WriteLine("you Lose!");
                Console.ReadKey();
                return;
            }
            else
            {
                if(wack == false)
                {
                    Console.WriteLine("You win!");
                    Console.ReadKey();
                    return;
                }
            }

           


          

         
        }
    }
}
