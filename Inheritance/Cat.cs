using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name; //i can able to access Name Property, because Cat is derived Class
        }

        public void GetName()
        {
            Console.WriteLine($"My cat name is {Name}");
        }
    }
}
