// using System;
//Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Console.WriteLine(dice.Next(1, 7))
// dice.Next(1, 7)

// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//     Console.WriteLine("You rolled triples! +6 bonus to total");
//     total += 6;
//     } else 
//     {
//     Console.WriteLine("You rolled doubles! +2 bonus to total");
//     total += 2;
//     }
//     Console.WriteLine($"Your total roll including the bonus: {total}")
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }



// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");


// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// int daysUntilExpiration = dice.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
// {
//     discountPercentage += 10;
// } 
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
// }
// string expireSoon = "Your subscription will expire soon. Renew now!";
// string expiresInDays = $"Your subcription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%";
// string expireOneDay = $"Your subscription will expire within a day. Renew now and save {discountPercentage}%";
// string expired = "Your subscription has expired.";

// if (daysUntilExpiration < 10)
// {
//     if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
//     {
//         Console.WriteLine(expiresInDays);
//     } 
//     else if (daysUntilExpiration == 1)
//     {
//         Console.WriteLine(expireOneDay);
//     }
//     else if (daysUntilExpiration < 1)
//     {
//         Console.WriteLine(expired);
//     }
//     else 
//     {
//         Console.WriteLine(expireSoon);
//     }
// }

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";


// string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// string[] names = {"Rowena", "Robin", "Bao"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = {200, 450, 700, 175, 250};

// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory");

// string[] fraudulentOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach (string fraudID in fraudulentOrderIDs)
// {
//     if (fraudID.StartsWith("B"))
//     {
//         Console.WriteLine(fraudID);
//     }
// }

// Convert message, convert to char and reverse. Then count and print 'o's

// string foxMessage = "The quick brown fox jumps over the lazy dog.";

// char[] charMessage = foxMessage.ToCharArray();
// Array.Reverse(charMessage);

// int oLetterCount = 0;

// foreach (char letter in charMessage) 
// { 
//     if (letter == 'o') 
//     { 
//     oLetterCount++; 
//     } 
// }

// string newMessage = new String(charMessage);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {oLetterCount} times.");



