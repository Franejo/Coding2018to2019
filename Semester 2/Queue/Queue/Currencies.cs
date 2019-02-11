using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Currencies : IComparable<Currencies>, IPrintable
    {
        int goldCount = 0;
        int silverCount = 0;
        int copperCount = 0;
        public Currencies(int goldCount, int silverCount, int copperCount)
        {
            this.goldCount = goldCount;
            this.silverCount = silverCount;
            this.copperCount = copperCount;
        }

        public int CompareTo(Currencies other)
        {
            if (other == null) return 1;
            int total = goldCount * 10000 + silverCount * 100 + copperCount;
            int otherTotal = other.goldCount * 10000 + other.silverCount * 100 + other.copperCount;
            int result = total > otherTotal ? 1 : -1;
            return total > otherTotal ? 1 : total < otherTotal ? -1 : 0;
        }
        

        public void Print()
        {
            Console.WriteLine("you have " + goldCount + "gold, " + silverCount + "silver, and " + copperCount + "copper coins");
        }
    }
}
