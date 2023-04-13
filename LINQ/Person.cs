using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set;}
        public string MobileNo { get; set; }
        public string City { get; set;}

        public Person(int id, string name,int age,string mobileNo,string city)
        {
            Id = id;
            Name = name;
            Age = age;
            MobileNo = mobileNo;
            City = city;
        }

    }
}
