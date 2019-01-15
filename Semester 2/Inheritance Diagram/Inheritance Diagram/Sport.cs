using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
   class Sport: Motorcycle
    {
        protected float accelspeed;
        protected float torquespeed;
        protected bool doeshavecompactbars;
        public Sport(float height, bool isloud, bool isfast, float weight, string make, float zero2sixty, float wheeliespeed, float accelspeed, float torquespeed, bool doeshavecompactbars)
            : base (weight, height, isloud, isfast, make, zero2sixty, wheeliespeed)
        {
            this.accelspeed = accelspeed;
            this.torquespeed = torquespeed;
            this.doeshavecompactbars = doeshavecompactbars;
        }
    }
}
