using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
   abstract class car: Motorized_vehicle
    {
        protected float zero2sixty = 0f;
        protected int numofwheel = 0;
        protected string cartype;
        protected string carengine;

        public car(string cartype , string carengine, int numofwheel, float zero2sixty, float weight, float height, bool isloud, bool isfast)
            : base (weight, height, isloud, isfast)
        {
            this.zero2sixty = zero2sixty;
            this.numofwheel = numofwheel;
            this.cartype = cartype;
            this.carengine = carengine;
        }
    }
}
