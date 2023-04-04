
using CSharpBatchMar23.Inheritance;


//Dog germanDog = new Dog();
//germanDog.Name = "German Sheperd";
//germanDog.Display();
//germanDog.GetName();

//Console.WriteLine("=====================");

//Cat persianCat = new Cat();
//persianCat.Name = "Iran Persian Cat";
//persianCat.Display();
//persianCat.GetName();


// PROTECTED
Dog germanDog = new Dog("German Sheperd");
//germanDog.Name = "German Sheperd"; i cannot able to acces from outside the class
germanDog.Display();
germanDog.GetName();

Console.WriteLine("=====================");

Cat persianCat = new Cat("Iran Persian Cat");
//persianCat.Name = "Iran Persian Cat"; i cannot able to acces from outside the class
persianCat.Display();
persianCat.GetName();