using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringTimes("hi", 2));
            Console.WriteLine(StringTimes("hi", 3));
            Console.WriteLine(StringTimes("hi", 1));
            Console.ReadLine();
        }
       public static string StringTimes(string x, int i)
        {
            string lop = "";
            do
            {
              lop += x;
                i--;
            }
            while (i > 0);

            return lop;
        }
    }
}
