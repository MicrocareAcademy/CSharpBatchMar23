using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Interface
{
    public class Rectangle : IPolygon,IColor // rectangle class is implementing the interface IPolygon
    {
        private int Length { get; set; }
        private int Breadth { get; set; }
        private string Colour { get; set; }
        public Rectangle(int length, int breadth,string color)
        {
            Length = length;
            Breadth = breadth;
            Colour = color;
        }

        public void Area()
        {
            // implementation

            int area = Length * Breadth;

            Console.WriteLine("Area of Rectangle: " + area);


        }

        public void Color()
        {
            Console.WriteLine($"Rectangle Color is {Colour}");
        }
    }
}
