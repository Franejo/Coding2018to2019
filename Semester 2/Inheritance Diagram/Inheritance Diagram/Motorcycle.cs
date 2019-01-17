using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    abstract class Motorcycle: Motorized_vehicle
    {
        
        
        protected float wheeliespeed;

        public Motorcycle(float weight, float height, bool isloud, bool isfast, float zero2sixty, float wheeliespeed, string make)
           : base(weight, height, isloud, isfast, make, zero2sixty)
        {
           
            this.wheeliespeed = wheeliespeed;
        }

       
    }
}
