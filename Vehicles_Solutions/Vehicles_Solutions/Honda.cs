using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Solutions
{
    internal class Honda : Car, IMotorcycles
    {
       
        public enum Honda_Vehicles_Types { Car , MotorCycle};
        Honda_Vehicles_Types honda_vehicle_Type;

        public Honda(Honda_Vehicles_Types phonda_vehicle_Type)
        {
            honda_vehicle_Type = phonda_vehicle_Type;
        }

        public Honda(float pressure, float maximumTemperature) :
            base(pressure, maximumTemperature, Car_Manufacturers.Honda) { }
       
        public Honda(float pressure, float minimumTemperature, float thickness) :
            base(pressure, minimumTemperature, thickness, Car_Manufacturers.Honda) { }

        
        
        
        // checking Honda Vehicles Type in case it is car or motocycle
        void Check_Honda_Veciles_Type()
        {
            if (honda_vehicle_Type == Honda_Vehicles_Types.Car)
            {
                
                Car_manufacturer = Car_Manufacturers.Honda;
                base.Move();
            }
            else
            {
                Console.WriteLine("You are driving a motorcycle from Honda.");
                Console.WriteLine();
            }
        }
       
        public override void Move()
        {
            Check_Honda_Veciles_Type();
        }
    }
}
