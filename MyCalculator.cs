using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23
{
    public static class MyCalculator
    {
        static public int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        static public int Add(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }

        static public int Add(int num1, int num2, int num3,int num4)
        {
            return num1 + num2 + num3 + num4;
        }

        static public int Sub(int num1,int num2)
        {
            return num1 - num2;
        }

        static public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
