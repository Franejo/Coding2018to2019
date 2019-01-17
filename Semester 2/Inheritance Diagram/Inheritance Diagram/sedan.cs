using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class sedan : car
    {
        protected int numberofdoors;
        protected float topspeed;
        public sedan(string make, string carengine, int numofwheel, float zero2sixty, float weight, float height, bool isloud, bool isfast, int numberofdoors, float topspeed)
            : base(make, carengine, numofwheel, zero2sixty, weight, height, isloud, isfast)
        {
            this.numberofdoors = numberofdoors;
            this.topspeed = topspeed;
        }
        public override void printcar()
        {
            Console.WriteLine("\n\n\nnMake: " + make + "\nCarEngine: " + carengine + "\nNumber of wheels: " + numofwheel + "\nzero to sixty: " + zero2sixty + "\nweight: " + weight + "\nheight : " + height + "\nisloud: " + isloud + "\n Isfast: " + isfast +"\nnumberofdoors" + "\ntop speed: " + topspeed);
        }
    }
}
