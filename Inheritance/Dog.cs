using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class Dog : Animal // dog is a derived class and animal is a base class
    {
        public Dog()
        {

        }

        public Dog(string name)
        {
            Name = name;  // Name is protected property exist inside Base Class

           // as its protected it can be accessed within the baseclass or from derived classes
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine($"I am a dog");
        }
        
    }
}
