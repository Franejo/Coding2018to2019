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
            : base (weight, height, isloud, isfast,zero2sixty, wheeliespeed , make)
        {
            this.accelspeed = accelspeed;
            this.torquespeed = torquespeed;
            this.doeshavecompactbars = doeshavecompactbars;
        }
        public override void printcar()
        {
            Console.WriteLine("\n\n\nheight: " + height + "\nis it loud?: " + isloud + "\nis it fast?: " + isfast + "Weight: " + weight + "make: "+ make +"\nwhat is its zero to sixty speed?: " + zero2sixty + "\nwhats its wheelie speed?: " + wheeliespeed + "\nwhats its accel speed?: " + wheeliespeed + "\ntorquespeed: " + torquespeed + "\ndoes it have compact bars: " + doeshavecompactbars);

        }
    }
}
