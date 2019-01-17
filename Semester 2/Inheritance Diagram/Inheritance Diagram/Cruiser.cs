using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Cruiser : Motorcycle
    {
        protected bool doeshaveapehangers;
        protected bool isslower;
        protected bool isheavy;
        public Cruiser(bool doeshaveapehangers, bool isslower, bool isheavy, float weight, float height, bool isloud, bool isfast, string make, float zero2sixty, float wheeliespeed)
                    : base(weight, height, isloud, isfast, wheeliespeed, zero2sixty, make)
        {
            this.doeshaveapehangers = doeshaveapehangers;
            this.isslower = isslower;
            this.isheavy = isheavy;
        }
        public override void printcar()
        {
            Console.WriteLine("\n\n\nApe hangers?: " + doeshaveapehangers + "\nis slow?: " + isslower + "\nis it heavy?: " + isheavy + "\nheight: " + height + "\nisloud? : " + isloud + "\nisfast: " + isfast + "\nmake?: " + make + "\nZero to sixty time: " + zero2sixty + "\nwheelie speed: " + wheeliespeed);
                


        }

    }
}
