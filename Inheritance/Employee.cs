using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class Employee : Person
    {
        public Employee() 
        {
            // C# compiler will execute the parameterless Constructor of base class first
            // and then Employee Parameterless contrusctor of derived class
            Console.WriteLine("Employee Parameterless Const");
        }

        public Employee(string name) : base(name)
        {
            // we are explicitly telling the compiler to execute the base class
            // constructor with one parameter whose type should be string
            Console.WriteLine($"Employee Const with one parameter name: {name}");
        }

        public Employee(string name,int age) : base(name,age)
        {
            // we are explicitly telling the compiler to execute the base class
            // constructor with two parameter , data type should be string,int

            Console.WriteLine($"Employee Const with two parameters {name}/{age}");
        }


    }
}
