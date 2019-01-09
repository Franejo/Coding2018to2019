using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egresham_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            string uppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            
            
                for (int i = 0; i <= alphabet.Length - 1; i++)
                {
                int j = 96;

                    Console.WriteLine(alphabet[i] + " = " + j++);

                    

                }
              
            Console.ReadKey();

        }
    }
}
