using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Motorized_vehicle> motor_vehicle = new List<Motorized_vehicle>();

            motor_vehicle.Add(new Sport(3, true, true, 374 , "Suzuki GSX-R1000", 2.556f, 40,233,400, true));
            motor_vehicle.Add(new Cruiser(true,true,true,673f,3, true,false, "Harley Davidson: Fat Bob",4.2f,0f));
            motor_vehicle.Add(new touring(1360f, 30.7f, true, false, "Harley Davidson Electra Glide: Classic", 5f, 0f, true, true,true, true));
            motor_vehicle.Add(new sedan("2019 toyota Camry","2.5 liter I-4 Engine", 4, 5.8f,3351f,51.2f,true,true,4,120f));
            motor_vehicle.Add(new coup("2016 ferrari 488 GTB", "V8 3.9 litres",4,3,3252f,48f,true,true,4,205f));


            for (int i = 0; i < motor_vehicle.Count; i++)
            {
                motor_vehicle[i].printcar();

            }
            
        }
      
    }
}
