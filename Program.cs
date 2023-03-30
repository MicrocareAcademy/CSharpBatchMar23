using CSharpBatchMar23;

Student student1 = new Student(); // creating an object of class Student

//student1.firstName = "Sajjad"; // Field
student1.FirstName = "Sajjad"; // property

student1.LastName = "Khan"; // property
student1.Age = 34; // property

student1.IdentityNo = "12301230123012301";

Console.WriteLine($"Name:" +
    $"               {student1.FullName()}, " + // Getting the data from method
    $"             Age: {student1.Age}, " +  // getting the data from Field
    $"             IdentityNo: {student1.IdentityNo}");