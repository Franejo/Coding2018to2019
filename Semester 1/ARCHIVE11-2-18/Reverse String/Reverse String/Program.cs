using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = " ";
            string reverseString = " ";
            string lengthofstring;
            Console.WriteLine("Please input a simple statement you would like reversed");
            myString = Console.ReadLine();



            for (int i = 0; i < myString.Length; i++)
            {
                
                i = myString.Length;
                int b = 0;
                myString[i] = reverseString[b];
                i--;
                b++;

            }

            Console.ReadKey();

        }
    }
}
