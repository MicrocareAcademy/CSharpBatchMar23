

// int num = 0;  only one time initialization


// num < 20
// body will be executed
// iterator stmt, num ++ 

//Console.WriteLine("Numbers:");

//for(int num = 1; num <= 10; num++)
//{
//    // body of for loop
//    // body will be executed after condition(expression is true)

//    Console.Write($"{num} ");
//}

//int num = 1;
//for(;num <= 10;)  //for(int num = 1; num <= 10; num++)
//{
//    Console.Write($"{num} ");

//    num++;
//}

//int x = 0;
//for(;x < 1;)
//{
//    Console.Write($"{x}");
//}


// Summation of first 10 natural numbers

//int sum = 0;
//int noOfNaturalNumbers = Convert.ToInt32(Console.ReadLine());

//for(int num = 1; num <= noOfNaturalNumbers; num++)
//{
//    sum = sum + num;
//}

//Console.WriteLine($"Summation of first {noOfNaturalNumbers} natural numbers: {sum}");

//// 1+2+3+4+5+6+7+8+9+10 = 


// 10 to 1

//for(int num = 10; num >= 1; num--)
//{
//    Console.WriteLine($"Number: {num}");
//}



//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        break;
//    }

//    Console.WriteLine($"Value of i: {i}");
//}


//for (int i = 0,j=0; i + j < 5; i++, j++)
//{
//    Console.WriteLine($"Value of i: {i}, J: {j} ");
//}

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }

    Console.WriteLine();

}


/*
 1 = 1

 1 2 = 3
 
 1 2 3 = 6
 */