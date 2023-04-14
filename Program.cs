using CSharpBatchMar23.LINQ;
using System.Xml.Linq;

IList<Person> persons = new List<Person>()
{
    new Person(1, "Sajjad", 34, "123-123-1231", "Kurnool"),
    new Person(2, "Srikant", 25, "10023-00-1231", "Nandyal"),
    new Person(3, "Praveen", 24, "741-741-741", "Atmakur"),
    new Person(4, "Sushma", 24, "741-525-741", "Atmakur")
};

persons.Add(new Person(5, "Hammad", 26, "8888-741-741", "Hyderabad"));
persons.Add(new Person(5, "Sreenivasulu", 26, "999-741-741", "Kurnool"));
persons.Add(new Person(6, "Kalyani", 26, "9999-741-741", "Bangalore"));

//var firstPersonOfKnl = persons.Where(p => p.City == "Kurnool").First();

////var firstPersonOfKnl = persons.Where(p => p.City == "Newyork").FirstOrDefault();


//Console.WriteLine("First Person Of KNL");
//Console.WriteLine($"Name: {firstPersonOfKnl.Name} / ID: {firstPersonOfKnl.Id} / Mobile No: {firstPersonOfKnl.MobileNo}");

//var lastPersonOfKnl = persons.Where(p => p.City == "Kurnool").Last();
//Console.WriteLine("Last Person Of KNL");
//Console.WriteLine($"Name: {lastPersonOfKnl.Name} / ID: {lastPersonOfKnl.Id} / Mobile No: {lastPersonOfKnl.MobileNo}");


// I want to get only Names from the collection

//var names = (from p in persons
//             where p.City == "Kurnool"
//             select p.Name);


//var names2 = persons.Select(person => person.Name).ToList();

//foreach(var name in names2)
//{
//    Console.WriteLine(name);
//}



var personsWithBasicData = persons.Select(x => new 
                                                    { PersonID = x.Id,
                                                      PersonName = x.Name });

foreach(var person in personsWithBasicData)
{
    Console.WriteLine($"PersonID : {person.PersonID} , Name: {person.PersonName}");
}

