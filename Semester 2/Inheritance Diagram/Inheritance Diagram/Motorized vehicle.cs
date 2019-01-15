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
        public Motorized_vehicle(float weight, float height, bool isloud, bool isfast)
        {
            this.weight = weight;
            this.height = height;
            this.isloud = isloud;
            this.isfast = isfast;
        }

    }
}
