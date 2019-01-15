using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    abstract class Motorcycle: Motorized_vehicle
    {
        protected string make;
        protected float zero2sixty;
        protected float wheeliespeed;

        public Motorcycle(float weight, float height, bool isloud, bool isfast, string make, float zero2sixty, float wheeliespeed)
           : base(weight, height, isloud, isfast)
        {
            this.make = make;
            this.zero2sixty = zero2sixty;
            this.wheeliespeed = wheeliespeed;
        }
    }
}
