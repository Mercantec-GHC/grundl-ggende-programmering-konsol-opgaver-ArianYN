// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";


//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat pants";
//        break;
//    default:
//        type = "Other";
//        break;
//}

//switch (product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//        break;
//    case "WH":
//        color = "White";
//        break;
//}

//switch (product[2])
//{
//    case "S":
//        size = "Small";
//        break;
//    case "M":
//        size = "Medium";
//        break;
//    case "L":
//        size = "Large";
//        break;
//    default:
//        size = "One Size Fits All";
//        break;
//}
//Console.WriteLine($"Product: {size} {color} {type}");

// Iterate through code block using for statement in C#

//for (int i = 1; i < 100; i++)
//{
//    string keyword = "";
//    if (i % 3 == 0)
//    {
//        keyword += "Fizz";
//    }
//    if (i % 5 == 0)
//    {
//        keyword += "Buzz";
//    }

//    Console.WriteLine($"{i} {keyword}");
//}

// Add looping logic using do-while and while statements in C#

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);


//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}

//Console.WriteLine($"Last number: {current}");

Console.ReadLine();

