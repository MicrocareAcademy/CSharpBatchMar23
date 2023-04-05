using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Inheritance
{
    public class AsianCat : Cat    // AsianCat -> Cat -> Animal (Multilevel inheritance)
    {
        public AsianCat(string name)
        {
            this.Name = name;
        }

        public void GetAsianCatName()
        {
            Console.WriteLine($"My Asian cat name is {Name}");
        }
    }
}
