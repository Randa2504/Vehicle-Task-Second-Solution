using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Solutions
{
    internal class Toyota : Car
    {
        public Toyota() : base(Car_Manufacturers.Toyota) { }
        public Toyota(float pressure, float maximumTemperature)
            : base(pressure, maximumTemperature , Car_Manufacturers.Toyota) {}
        
        public Toyota(float pressure, float minimumTemperature, float thickness) :
            base(pressure, minimumTemperature, thickness , Car_Manufacturers.Toyota) {}
       
    }
}
