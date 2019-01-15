using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class touring: Motorized_vehicle
    {
        protected bool ishavepaneers;
        protected bool ishaveradio;
        protected bool ishaveheatedseats;
        protected bool speakers;
        public touring(float weight, float height, bool isloud, bool isfast, string make, float zero2sixty, float wheeliespeed, bool ishavepaneers, bool ishaveradio, bool ishaveheatedseats, bool speakers)
            : base (weight, height, isloud, isfast)
        {
            this.ishavepaneers = ishavepaneers;
            this.ishaveradio = ishaveradio;
            this.ishaveheatedseats = ishaveheatedseats;
            this.speakers = speakers;

        }
    }
}
