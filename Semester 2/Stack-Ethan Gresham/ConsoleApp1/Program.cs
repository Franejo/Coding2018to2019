using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            int whytho;
            do
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1-Push^^^^^^^^^^^^^^^^+");
                Console.WriteLine("2-Pop^^^^^^^^^^^^^^^^^+");
                Console.WriteLine("3-Peek^^^^^^^^^^^^^^^^+");
                Console.WriteLine("4-Print^^^^^^^^^^^^^^^+");
                Console.WriteLine("5-Exit Program^^^^^^^^+");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                whytho = int.Parse(Console.ReadLine());

                if (whytho == 1)
                {
                    Console.WriteLine("Yo chungus put in a numba");
                    int numb = int.Parse(Console.ReadLine());

                    myStack.Push(numb);
                }
                if (whytho == 2)
                {
                    
                   Console.WriteLine(myStack.Pop());
                }
                if (whytho == 3)
                {
                    Console.WriteLine(myStack.Peek());
                }
                if (whytho == 4)
                {
                    myStack.Print();
                }
            } while (whytho != 5);
           
        }

    }
}
