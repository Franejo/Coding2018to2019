using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myIntArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < myIntArray.Length; i++)
            {
                

                myIntArray[i] = rand.Next(10);
                Console.WriteLine(myIntArray[i]);





            }









            Console.ReadLine();


        }
    }
}
