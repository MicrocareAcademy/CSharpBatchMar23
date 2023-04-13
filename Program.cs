
using CSharpBatchMar23.LINQ;

IList<int> ages = new List<int>();
ages.Add(10);

IList<int> userIds = new List<int>() 
                                { 1, 2, 3, 4, 5, 6 };



foreach (var age in ages)
{

}


//IList<Person> persons = new List<Person>();

//var p1 = new Person(1, "Sajjad", 34, "123-123-1231", "Kurnool");
//persons.Add(p1);

//var p2 = new Person(1, "Srikant", 25, "10023-00-1231", "Kurnool");
//persons.Add(p2);

//var p3 = new Person(1, "Praveen", 24, "741-741-741", "Kurnool");
//persons.Add(p3);

IList<Person> persons = new List<Person>()
{
    new Person(1, "Sajjad", 34, "123-123-1231", "Kurnool"),
    new Person(2, "Srikant", 25, "10023-00-1231", "Kurnool"),
    new Person(3, "Praveen", 24, "741-741-741", "Kurnool")
};

persons.Add(new Person(4, "Hammad", 26, "8888-741-741", "Kurnool"));

var srikantPer = persons.FirstOrDefault(p => p.Id == 2);

srikantPer.Name = "SAI Srikant";

foreach (Person p in persons)
{
    
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, City: {p.City}");
}


