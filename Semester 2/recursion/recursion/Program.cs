using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                integers.Add(rand.Next(0, 1000));
                integers.Sort();
                
            }
            bool result = SearchIntList(integers, 12);
            Console.WriteLine(result);
        }
        public static bool SearchIntList(List<int> integers,int n)
        {
            return SearchIntListRecursive(integers, n, 0,integers.Count - 1);
        }
        private static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
            {
                //if the lowerbound and upperbound are the same, return false
                return true;
                
            }
            //Store the midpoint between lowerbound and upper bound

            int midpoint = upperBound - lowerBound;
            midpoint = midpoint / 2;
            midpoint += lowerBound;
            //if the integer at index is equal to N, we can return true cause it found N
            if (integers[midpoint] == n)
            {
                return true;
            }
            // if the upperbound and lower bound are 1 unit apart, return false
            if(upperBound - lowerBound ==  1)
            {
                return false;
            }
            // if the integer at index is greater than n, we know n will be to the left
            //return the recursive call but modify bounds to ignore everything > index

            if (integers[midpoint] >n)
            {
                return SearchIntListRecursive(integers,n,lowerBound,midpoint);
            }

            // if the integer at index is less than n, we know that n will be to the right
            // return the recursive call but modify bounds to ignore everything <index
            if (integers[midpoint] < n)
            {
                return SearchIntListRecursive(integers, n, midpoint, upperBound);
            }
            //we havent found it, return false

            else
            {
                return false;

            }
        }
        
    }
}
