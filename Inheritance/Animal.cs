using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class Animal
    {
        protected string Name { get; set; } 
        // can be accessed within the same class or from its derived classes

        public virtual void Display()
        {
            Console.WriteLine("I am an Animal ...");
        }
    }
}
