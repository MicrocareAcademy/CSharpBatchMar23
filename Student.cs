using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23
{
    public class Student
    {
        public string FirstName;

        public string LastName;

        public int Age;

        public DateTime DOB;

        public string IdentityNo;


        public string FullName()
        {
            return FirstName +" "+ LastName;
        }
    }
}
