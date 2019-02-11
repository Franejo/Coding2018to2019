using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class QueueGeneric<t> : IEmptyable, IPrintable, ICountable where t : IComparable
    {
        
        
        List<t> queue = new List<t>();
        public int Count()
        {
            throw new NotImplementedException();
        }
        public void Empty()
        {
            throw new NotImplementedException();

        }
        //push
        public void Enqueue(t val)
        {

            queue.Insert(0,val);
        }
        //pop
        public t Dequeue()
        {
            if (queue.Count < 1)
            {
                t Boolin = queue[0];
                queue.RemoveAt(0);
                return Boolin;
            }
            else return default(t);
            
                 
        }
        // peek
        public t Peek()
        {
            if (queue.Count < 1)
            {
                return queue[queue.Count - 1];
            }
            else return default(t);
        }
        // print
        public void Print()
        {
            for (int i = 0; i < queue.Count - 1; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }

      
    }
}
        

   