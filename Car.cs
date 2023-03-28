using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23
{
    public class Car
    {
        // Fields (associated piece of data)
        public string Model;
        public int Year;
        public bool IsAutomatic;
        public string Company;
        public double Fuel = 100;

        // Methods (block of statements to perform some specific task
        
        public void DecreaseFuel(int value)
        {
            Fuel = Fuel - value;
        }

        public void IncreaseFuel(int value)
        {
            Fuel = Fuel + value;
        }

        public void DisplayFuel()
        {
            Console.WriteLine($"Car {Model}, Fuel:{Fuel}");
        }

        public void DisplayKmsTravelled(int noOfKms)
        {
            Console.WriteLine($"Car {Model} travelled {noOfKms}");
        }
    }
}
