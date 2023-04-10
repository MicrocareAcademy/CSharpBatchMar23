using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Abstract
{
    public abstract class Animal
    {
        // abstract class, we cannot able to create an object

        // abstract class contains Abstract methods and Non-Abstract Methods

        public abstract void Sound(); 
        //abstract methods has no implementation only declaration
        // abstract methods implicity its VIRTUAL
        // abstract methods must be implemented by derived classes

    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog used to Bark..");
        }
    }

    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat used to meo meo..");
        }
    }
}
