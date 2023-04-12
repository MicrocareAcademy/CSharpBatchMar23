using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Polymorphism
{
    public class Drawing
    {
        public virtual void Area()
        {
            Console.WriteLine("Area Method in Drawing Class");
        }
    }

    public class Square : Drawing
    {
        public override void Area()
        {
            Console.WriteLine("Area Method in Square Class");
        }
    }
}
