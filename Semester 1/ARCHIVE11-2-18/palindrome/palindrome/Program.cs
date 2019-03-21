using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "";
            do
            {
                // Ethan Gresham
                // just a quick note, this code is kind of random. It is the result from 3 hours of research into c#. At the time of writing it, it made complete sense. But it doesnt anymore. however it still works.
                // on wednesday do you think i can go over it with you and you can explain it deeper?
                Console.Write("Enter something for to check that is it palindrome, input exit to leave :");// asks for a palindrome
                palindrome = Console.ReadLine(); // declares a string and makes the input the string
                int length = palindrome.Length;// declares a int and makes the int relative to 0 and the same length as palindrome.
                bool truFal = true;// bool for easy if else later.


                for (int i = 0; i < length / 2; i++)// declares i, and as long as i is less than length divided by 2. then adds one to i every rotation. 
                {
                    if (palindrome[i] != palindrome[length - (i + 1)])// if the i'th element of palindrome does not equal the [length - (i +1)]'th element of palindrome, then it is not a palindrome.
                    {
                        truFal = false;// if the above is true, makes the bool false
                        break;// break because this would have run forever if not.
                    }
                }


                if (truFal)// if it is false:
                {
                    Console.WriteLine(palindrome + " is a palindrome!");// declares it is a palindrome
                }
                else// else
                {
                    Console.WriteLine(palindrome + " is not palindrome!");// declares it is not a palindrome
                }
                Console.ReadLine(); // readline in order to pause the program for reading.
            } while (palindrome != "exit");
                
    }
        }
    
    }

