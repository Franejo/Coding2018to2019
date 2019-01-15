using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class sedan: car
    {
        protected int numberofdoors;
        protected float topspeed;
        public sedan(string cartype, string carengine, int numofwheel, float zero2sixty, float weight, float height, bool isloud, bool isfast, int numberofdoors, float topspeed)
            : base(cartype, carengine, numofwheel, zero2sixty, weight, height, isloud, isfast)
        {
            this.numberofdoors = numberofdoors;
            this.topspeed = topspeed;
        }
    }
}
