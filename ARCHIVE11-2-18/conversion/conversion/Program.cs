using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int lotnumber;
            char character;

            for (lotnumber = 0; lotnumber <= 64500; lotnumber++)
            {
                character = (char)lotnumber;
                Console.Write(character);
                
            }
            Console.ReadKey();
        }
    }
}
