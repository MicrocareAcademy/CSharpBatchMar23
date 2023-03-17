// String.Join() / String.Split()

//string[] names = {"Microcare","Academy"};

//string fullName = string.Join("--", names);

//Console.WriteLine($"Full Name : {fullName}");


//string[] userIds = { "1", "2", "3", "4" };

//string userIdsStr = string.Join(",", userIds);

//Console.WriteLine($"User Ids : {userIdsStr}");


//// Creating a string array
//string[] courses = { "C#", "Java", "C++", "Swift", "Go" };

//// joins 2 strings from index 1
//string s1 = String.Join("-", courses, 0, 2);

//Console.WriteLine(s1);

//Console.ReadLine();



//string userIdsStr = "1,2,3,4,5";

// userIdsArr = {1,2,3,4,5};


string[] courseDetails = { "C#"," ", "is","a","fun","programming","language"};

string courseText = String.Join(" ", courseDetails);

string[] backToNormalCourse = courseText.Split(' ', 4, StringSplitOptions.RemoveEmptyEntries);

for(int i = 0; i < backToNormalCourse.Length; i++)
{
    Console.WriteLine(backToNormalCourse[i]);
}

//Console.ReadLine();


string micStr = "1,2,3,4,&,6";
string[] mySeperators = { ",", "&" };

string[] myTextArr = micStr.Split(mySeperators,StringSplitOptions.RemoveEmptyEntries);

Console.ReadLine();


