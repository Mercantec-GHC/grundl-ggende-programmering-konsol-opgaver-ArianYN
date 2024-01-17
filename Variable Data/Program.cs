//Console.WriteLine("Signed integral types:");

//Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
//Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
//Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
//Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Console.WriteLine("");
//Console.WriteLine("Unsigned integral types:");

//Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
//Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
//Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
//Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//Console.WriteLine("");
//Console.WriteLine("Floating point types:");
//Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//int[] data = new int[3];

//int first = 2;
//string second = "4";
//int result = first + second;
//Console.WriteLine(result);

//string value = "value";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report measurement");
//}
//if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal number = 0m;
//string message = "";

//foreach (string value in values)
//{
//    decimal foundNumber;
//    if (decimal.TryParse(value, out foundNumber))
//    {
//        number += foundNumber;
//    }
//    else
//    {
//        message += value;
//    }
//}

//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {number}");

//int value1 = 12;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

//int result1 = value1 / (int)value2;
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//decimal result2 = value2 / (decimal)value3;
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//float result3 = value3 / value1;
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//// string result = new string(valueArray);
//string result = String.Join(",", valueArray);
//Console.WriteLine(result);

//string[] items = result.Split(',');
//foreach (string item in items)
//{
//    Console.WriteLine(item);
//}

//string pangram = "The quick brown fox jumps over the lazy dog";

//string[] noSpaceMessages = pangram.Split(' ');

//string[] reversedWordMessage = new string[noSpaceMessages.Length];

//for (int i = 0; i < noSpaceMessages.Length; i++)
//{
//    char[] word = noSpaceMessages[i].ToCharArray();
//    Array.Reverse(word);
//    reversedWordMessage[i] = new string(word);
//}

//string finalResult = string.Join(" ", reversedWordMessage);
//Console.WriteLine(finalResult);

//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[] orderIDs = orderStream.Split(',');
//Array.Sort(orderIDs);

//foreach (string order in orderIDs)
//{
//    if (order.Length == 4)
//    {
//        Console.WriteLine(order);
//    }
//    else
//    {
//        Console.WriteLine(order + "\t- Error.");
//    }
//}

//int invoiceNumber = 1201;
//decimal productShares = 25.4568m;
//decimal subtotal = 2750.00m;
//decimal taxPercentage = .15825m;
//decimal total = 3185.19m;

//Console.WriteLine($"Invoice Number: {invoiceNumber}");
//Console.WriteLine($"   Shares: {productShares:N3} Product");
//Console.WriteLine($"     Sub Total: {subtotal:C}");
//Console.WriteLine($"           Tax: {taxPercentage:P2}");
//Console.WriteLine($"     Total Billed: {total:C}");

//string paymentId = "769C";
//string payeeName = "Mr. Stephen Ortega";
//string paymentAmount = "$5,000.00";

//var formattedLine = paymentId.PadRight(6);
//formattedLine += payeeName.PadRight(24);
//formattedLine += paymentAmount.PadLeft(10);

//Console.WriteLine("1234567890123456789012345678901234567890");
//Console.WriteLine(formattedLine);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently you own {currentShares} shares at a return rate of {currentReturn} %");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn} %. Given your current volume, your potential profit would be {newProfit:C}");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

//I copied this, as i was confused about what to do with the comparisonMessage
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Your logic here

Console.WriteLine(comparisonMessage);

Console.ReadLine();