using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Interface
{
    public class Square : IPolygon, IColor
    {
        private int Side { get; set; }
        private string Colour { get; set; }

        public Square(int side,string color)
        {
            Side = side;
            this.Colour = color;
        }

        public void Area()
        {
            // implementation
            int area = Side * Side;

            Console.WriteLine("Area of Square: " + area);
        }

        public void Color()
        {
            Console.WriteLine($"Color of Square is {Colour}");
        }
    }
}
