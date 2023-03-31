using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23
{
    public class Student
    {
        #region ### Fields ###

        private string firstName; // FIELD

        // ANother way of settings and getting data from field using methods
        public void SetFirstName(string fName)
        {
            firstName = fName;
        }
        public string GetFirstName()
        {
            return firstName;
        }

        public string FirstName  // PROPERTY(this is spokeperson for the FIELD
        {
            get
            {
                return firstName;  // whenever i am accessing the property, get method will be called
            }
            set
            {
                firstName = value;  // whenever i am setting the property, set method will be called
            }
        }

       
        public string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public DateTime DOB { get; set; }

        public string IdentityNo { get; private set; } // automatic property
        
        public void SetIdentityNo(string no)
        {
            IdentityNo = no;
        }
        public string FullName()
        {
            return FirstName +" "+ LastName;
        }

        #endregion

        #region ### Constructors ###

        public Student() // parameterless constructor
        {
            Console.WriteLine("An Object of the class Student was created.");
        }

        // PARAMETERIZED CONSTRUCTOR
        public Student(string firstName,string lastName,int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Student(
            string firstName, 
            string lastName, 
            int age, 
            DateTime dOB, 
            string identityNo = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DOB = dOB;
            IdentityNo = identityNo;
        }


        #endregion

    }
}
