using CSharpBatchMar23.LINQ;


//IList<Person> persons = null;

//persons.Add(new Person(1, "Sajjad", 40, "123-123-123-1", "Kurnool"));

//try
//{
//    int x = 10;
//    int y = 20;
//    int z = x + y;

//    Console.WriteLine("try block executed");

//    IList<Person> persons = null;

//    persons.Add(new Person(1, "Sajjad", 40, "123-123-123-1", "Kurnool"));


//    foreach(var person in persons)
//    {
//        Console.WriteLine($"Person Details: {person.Name} , Age: {person.Age}");
//    }

//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Error Message:{ex.Message}");
//    Console.WriteLine($"Error Source:{ex.Source}");
//    Console.WriteLine($"Error Stack:{ex.StackTrace}");
//}
//finally
//{
//    Console.WriteLine("finally block executed");
//}


try
{
    IList<Person> persons = new List<Person>();

    persons.Add(new Person(1, "Sajjad", 40, "123-123-123-1", "Kurnool"));

    int i = 20;
    int result = i / 0;    // Suspect code  
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Attempted divide by zero");
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Nullable Exception, try to do operation on nullables");
}
catch (Exception ex)
{
    Console.WriteLine($"Error Message:{ex.Message}");
}