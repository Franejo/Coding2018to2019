using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
   abstract class car: Motorized_vehicle
    {

        protected int numofwheel = 0;
        
        protected string carengine;

        public car(string make, string carengine, int numofwheel, float zero2sixty, float weight, float height, bool isloud, bool isfast)
            : base (weight, height, isloud, isfast, make, zero2sixty)
        {
           
            this.numofwheel = numofwheel;
           
            this.carengine = carengine;
        }
    }
}
