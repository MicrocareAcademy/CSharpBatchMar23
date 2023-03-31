using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23
{
    public class Car
    {
        #region *** Fields ***

        // Fields (associated piece of data)
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsAutomatic { get; set; }
        public string Company { get; set; }
        public double Fuel { get; set; }

        // Methods (block of statements to perform some specific task



        #endregion

        #region *** Methods ***
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
        #endregion

        #region ### Constructors ###
        public Car()
        {

        }

        public Car(string Model)
        {
            this.Model = Model;
        }
        #endregion

    }
}
