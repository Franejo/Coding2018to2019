using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


           Random rand = new Random();
            int[] myIntArray = new int[11];
            List<int> myIntList = new List<int>();
            for (int i = 0; i < 10; i++)
            {


                myIntArray[i] = rand.Next(10);

                Console.WriteLine("Your number is: " + myIntArray[i]);
                
          

              


                myIntList.Add(rand.Next(10));

                Console.WriteLine("Your number is: " + myIntList[i]);
               // Console.ReadLine();

            }

            for(int i=0; i <10; i++)
            {
                Console.WriteLine(myIntArray[i]);
               
               

            }





        }
    }

 
}