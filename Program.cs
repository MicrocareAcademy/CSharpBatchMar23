﻿

// Return Type | Method Name | Parameters(optional)


using CSharpBatchMar23;

void display()
{
    // my block of method, where i can write statements 
}

int sum(int num1, int num2)
{
    var addition = num1 + num2;

    return addition;
}
bool isValid()
{
    return false;
}

int SumOfNumbers(List<int> numbers)
{
    var sum = 0;

    foreach(var num in numbers)
    {
        sum = sum + num;
    }

    return sum;
}

var addResult = sum(100,200);
Console.WriteLine($"Summation Of numbers: {addResult}");

List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var sumOfNumList = SumOfNumbers(numList);
var sumOfNumList2 = SumOfNumbers(numList);
var sumOfNumList3 = SumOfNumbers(numList);


int add1 = MyCalculator.Add(10,20,30);
int sum1 = MyCalculator.Sub(30, 20);
int mulply1 = MyCalculator.multiply(10, 50);



// Burger
/*
 
 Things needed to prepare burger 

 1. Prepare Breads
 2. Prepare Salads
 3. Prepare Patty
 4. Prepare Cheese Slice


Double Patty Burger
Add Breads
Add Salad
Add Patty
Add Cheese
Add Patty
Add Cheese


Double Patty with Extra Cheese Burger
Add Breads
Add Salad
Add Patty
Add Cheese
Add Patty
Add Cheese
Add Cheese
Add Cheese

 */

Console.WriteLine("====Preparing Veg Burger ====");
Burger.PrepareBreads();
Burger.PrepareSalad();
Burger.PrepareVegPatty();
Burger.PrepareCheeseSlice();


Console.WriteLine("====Preparing Chicken Burger extra cheese ====");

Burger.PrepareBreads();
Burger.PrepareSalad();
Burger.PrepareChickePatty();
Burger.PrepareCheeseSlice();
Burger.PrepareCheeseSlice();
Burger.PrepareCheeseSlice();

