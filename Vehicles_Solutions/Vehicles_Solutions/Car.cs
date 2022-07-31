using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Solutions
{
    internal abstract class Car : IVehicle
    {
        public enum Car_Manufacturers { Honda, Toyota };
        public Car_Manufacturers Car_manufacturer { get; set; }

        enum Tires_Types { Winter, Summer };
        Tires_Types Tires_Type;

        float Pressure = (float)2.5;
        float MaximumTemperature = 50;
        float? MinimumTemperature = null;
        float? Thickness = null;



        public Car() { }

        public Car (Car_Manufacturers car_manufacturer)
        {
            Car_manufacturer = car_manufacturer;
        }

        public Car(float pressure, float maximumTemperature, Car_Manufacturers car_manufacturer)
        {
            Pressure = pressure;
            MaximumTemperature = maximumTemperature;
            Car_manufacturer = car_manufacturer;

        }
        public Car(float pressure, float minimumTemperature, float thickness, Car_Manufacturers car_manufacturer)
        {
            Pressure = pressure;
            MinimumTemperature = minimumTemperature;
            Thickness = thickness;
            Car_manufacturer = car_manufacturer;
        }

        //Check for tires type
        void TiresType()
        {
            if (MinimumTemperature == null && Thickness == null)
                Tires_Type = Tires_Types.Summer;
            else
                Tires_Type = Tires_Types.Winter;
        }

        //display tires properties on screen
        void Display_Tires_properties()
        {
            TiresType();

            Console.WriteLine("your car is using " + Tires_Type + " Tires");
            Console.WriteLine("Pressure is set to " + Pressure + " bar.");

            if (Tires_Type == Tires_Types.Summer)
            {
                Console.WriteLine("Maximum Temperature is set to " + MaximumTemperature + "°C");
            }
            else
            {
                Console.WriteLine("Minimum Temperature is set to " + MinimumTemperature + "°C");
                Console.WriteLine("Thickness is set to " + Thickness + " cm.");
            }
        }

        public virtual void  Move()
        {
            Console.WriteLine("You are driving a car from " + Car_manufacturer);
            Display_Tires_properties();
            Console.WriteLine();
        }
    }
}
