using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_Solutions
{
    internal class KTM : IMotorcycles
    {
        public void Move()
        {
            Console.WriteLine("You are driving a motorcycle from KTM.");
            Console.WriteLine();
        }
    }
}
