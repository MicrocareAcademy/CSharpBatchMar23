using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Parameterless Const");
        }

        public Person(string name)
        {
            Console.WriteLine("Person Const with one parameter name");
        }

        public Person(string name,int age)
        {
            Console.WriteLine("Person Const with two parameter name and age");
        }
    }
}
