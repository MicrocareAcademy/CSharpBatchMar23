using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Abstract
{
    public abstract class MotorBike
    {
        public abstract void Brake(); // by default virtual

        public void DisplayModel() // non-Abstract Methods
        {

        }
    }

    public class SportsBike : MotorBike
    {
        public override void Brake()
        {
            Console.WriteLine("Sports bike braking system ...");
        }
    }

    public class StreetBike : MotorBike
    {
        public override void Brake()
        {
            Console.WriteLine("Street Bike Braking System..");
        }
    }
}
