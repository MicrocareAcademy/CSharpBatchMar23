using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Console.WriteLine($"My dog name is {Name}");
        }
    }
}
