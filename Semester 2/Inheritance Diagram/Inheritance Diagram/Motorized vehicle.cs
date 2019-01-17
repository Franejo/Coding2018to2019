using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    abstract class Motorized_vehicle
    { 
       public float weight;
        public float height;
       public  bool isloud;
      public  bool isfast;
        public string make;
        public float zero2sixty;
        public Motorized_vehicle(float weight, float height, bool isloud, bool isfast, string make,float zero2sixty)
        {
            this.zero2sixty = zero2sixty;
            this.make = make;
            this.weight = weight;
            this.height = height;
            this.isloud = isloud;
            this.isfast = isfast;
        }
        public abstract void printcar();
        

    }
}
