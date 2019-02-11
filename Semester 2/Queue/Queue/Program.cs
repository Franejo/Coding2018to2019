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
            QueueGeneric<float> qf = new QueueGeneric<float>();
            QueueGeneric<int> qi = new QueueGeneric<int>();
            QueueGeneric<string> qs = new QueueGeneric<string>();

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

                    qi.Enqueue(numb);
                }
                if (whytho == 2)
                {

                    Console.WriteLine(qi.Dequeue());
                }
                if (whytho == 3)
                {
                    Console.WriteLine(qi.Peek());
                }
                if (whytho == 4)
                {
                    qi.Print();
                }
            } while (whytho != 5);
            Console.WriteLine();
        }
    }
}
