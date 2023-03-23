
var names = new List<string>() { "MICROCAR", "EALLIANCE", "DZEN","Accenture","Cisco","Delliote" };

// Adding data
names.Add("INUBE");
names.Add("Terrlogic");

// inserting data to specific position
names.Insert(1, "Infosys");

// removing data
names.Remove("INUBE");

// remove data from specific position
names.RemoveAt(1);


// modify the data(replace)
names[0] = "MICROCARE Academy";

// sorting the data inside collection
names.Sort();

List<string> corpNames = new List<string>();

foreach (var name in names)
{
    corpNames.Add(name);
}




List<string> copyList = names;


