using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    class A
    {
        public virtual void Method()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void Method()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public override void Method()
        {
            Console.WriteLine("C");
        }
    }

    //class D : B, C
    //{

    //}
}
