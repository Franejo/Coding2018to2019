using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class touring: Motorcycle
    {
        protected bool ishavepaneers;
        protected bool ishaveradio;
        protected bool ishaveheatedseats;
        protected bool speakers;
        public touring(float weight, float height, bool isloud, bool isfast, string make, float zero2sixty, float wheeliespeed, bool ishavepaneers, bool ishaveradio, bool ishaveheatedseats, bool speakers)
            : base (weight, height, isloud, isfast, zero2sixty, wheeliespeed, make)
        {
            this.ishavepaneers = ishavepaneers;
            this.ishaveradio = ishaveradio;
            this.ishaveheatedseats = ishaveheatedseats;
            this.speakers = speakers;

        }
        public override void printcar()
        {
            Console.WriteLine("\n\n\nweight: " + weight + "\nHeight: " + height + "\nis it loud: " + isloud + "Is fast?: " + isfast + "make: " + make + "zero to sixty: " + zero2sixty + "wheelie speed : " + wheeliespeed + "Paneers? : " + ishavepaneers + "does it have radio?: " + ishaveradio + "is have heated seats?: "+ ishaveheatedseats + "is have speakers?: "+ speakers);

        }
    }
}
