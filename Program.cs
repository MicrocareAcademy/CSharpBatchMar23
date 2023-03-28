

using CSharpBatchMar23;

Student student1 = new Student(); // creating an object of class Student
student1.FirstName = "Sajjad";
student1.LastName = "Khan";
student1.Age = 34;
student1.IdentityNo = "12301230123012301";

Console.WriteLine($"Name: {student1.FullName()}, Age: {student1.Age}, IdentityNo: {student1.IdentityNo}");


Student student2 = new Student();
student2.FirstName = "Srikant";
student2.LastName = "Reddy";
student2.Age = 25;
student2.IdentityNo = "231-123-123-13";

Console.WriteLine($"Name: {student2.FullName()}, Age: {student2.Age}, IdentityNo: {student2.IdentityNo}");


Car c1 = new Car();
c1.Model = "Mercedes C9";
c1.Year = 2022;
c1.Company = "Mercedes";
c1.IsAutomatic = true;
c1.Fuel = 100;

c1.DisplayFuel();

c1.DisplayKmsTravelled(20);

c1.DecreaseFuel(30);

c1.IncreaseFuel(20);

c1.DisplayFuel();