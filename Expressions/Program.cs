﻿//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));

//int saleAmount = 1001;
////int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50

//Random coinflip = new Random();
//int flip = coinflip.Next(0, 2);
//Console.WriteLine(flip == 0 ? "Heads" : "Tails");

//string permission = "Admin|Manager";
//int level = 55;

//if (permission.Contains("Admin"))
//{
//    if (level > 55)
//    {
//        Console.WriteLine("Welcome, Super Admin user.");
//}
//    else 
//    {
//        Console.WriteLine("Welcome, Admin user.");
//    }
//}
//else if (permission.Contains("Manager"))
//{
//    if (level >= 20)
//    {
//        Console.WriteLine("Contact an Admin for access.");
//    }
//    else
//    {
//        Console.WriteLine("You don't have sufficient privileges.");
//    }
//}
//else
//{
//    Console.WriteLine("You don't have sufficient privileges.");
//}

//string name = "steve";
//if (name == "bob")
//    Console.WriteLine("Found Bob");

//else if (name == "steve") '
//    Console.WriteLine("Found Steve");

//else
//    Console.WriteLine("Found Chuck");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");

Console.ReadLine();

