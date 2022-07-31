using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Honda car with default 
            Honda honda = new Honda(Honda.Honda_Vehicles_Types.Car);
            honda.Move();
            //Honda with summer Tire
            Honda honda_SummerTire = new Honda((float)0.7, 150);
            honda_SummerTire.Move();
            //Honda with Winter Tire
            Honda honda_WinterTire = new Honda((float)0.99, 100, 200);
            honda_WinterTire.Move();


            //honda Motorcycle
            Honda hondamotorcycle = new Honda(Honda.Honda_Vehicles_Types.MotorCycle);
            hondamotorcycle.Move();



            //Toyota car with default 
            Toyota toyota = new Toyota();
            toyota.Move();
            //Toyota with summer Tire
            Toyota toyota_SummerTire = new Toyota((float)0.6, 300);
            toyota_SummerTire.Move();
            //Toyota with Winter Tire
            Toyota toyota_WinterTire = new Toyota((float)0.1, 500, 400);
            toyota_WinterTire.Move();


            //KTM motorcycle
            KTM ktm = new KTM();
            ktm.Move();


        }
    }
}
