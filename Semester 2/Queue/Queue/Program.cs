using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            queue myQueue = new queue();
            int whytho;
            do
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1-Enqueue^^^^^^^^^^^^^^^^+");
                Console.WriteLine("2-Dequeue^^^^^^^^^^^^^^^^^+");
                Console.WriteLine("3-Peek^^^^^^^^^^^^^^^^+");
                Console.WriteLine("4-Print^^^^^^^^^^^^^^^+");
                Console.WriteLine("5-Exit Program^^^^^^^^+");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                whytho = int.Parse(Console.ReadLine());

                if (whytho == 1)
                {
                    Console.WriteLine("Yo chungus put in a numba");
                    int numb = int.Parse(Console.ReadLine());

                    myQueue.Enqueue(numb);
                }
                if (whytho == 2)
                {

                    Console.WriteLine(myQueue.Dequeue());
                }
                if (whytho == 3)
                {
                    Console.WriteLine(myQueue.Peek());
                }
                if (whytho == 4)
                {
                    myQueue.Print();
                }
            } while (whytho != 5);
        }
    }
}
