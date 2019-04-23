using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary_tree mine = new Binary_tree();
            mine.Insert('a');
            


            mine.Insert('b');
            mine.Insert('b');

            mine.Insert('x');

            mine.Insert('c');
            mine.Insert('v');

            mine.Insert('i');

            mine.Insert('z');
            mine.print();
            ;
            Console.WriteLine(mine.Search('z'));
            Console.ReadLine();
        }
    }
}
