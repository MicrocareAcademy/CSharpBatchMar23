using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.UserInfo
{
    public partial class UserInfo
    {
        public string GetFullName()
        {
            return "FirstName" + "LastName";
        }

        public double CalculateGrossPrice()
        {
            return this.Quantity * this.UnitPrice;
        }
    }
}
