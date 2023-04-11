using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Interface
{
    public interface IPolygon
    {
        void Area();  // abstract method without access modifiers
                     // interface will not allow access modifiers


    }

    public interface IColor
    {
        void Color();
    }
}
