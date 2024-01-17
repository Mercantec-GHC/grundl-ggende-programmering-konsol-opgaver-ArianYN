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

//Random random = new Random();
//int current = random.Next(1, 11);

//do
//{
//    current = random.Next(1, 11);

//    if (current >= 8) continue;

//    Console.WriteLine(current);
//} while (current != 7);


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


//int heroHealth = 10;
//int enemyHealth = 10;

//do
//{
//    Random diceRoll = new Random();
//    int roll = diceRoll.Next(1, 11);
//    enemyHealth -= roll;

//    if (enemyHealth < 0)
//    {
//        enemyHealth = 0;
//    }

//    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {enemyHealth} health.");

//    if (enemyHealth <= 0)
//    {
//        continue;
//    }

//    roll = diceRoll.Next(1, 11);
//    heroHealth -= roll;

//    if (heroHealth < 0)
//    {
//        heroHealth = 0;
//    }

//    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");

//} while (heroHealth > 0 && enemyHealth > 0);

//Console.WriteLine(heroHealth > enemyHealth ? "The Hero has won" : "The monster has won!");

Console.WriteLine("Input an integer between 5 and 10:");
string integerInput;
bool validnumber = false;
int inputNumber;

do
{
    integerInput = Console.ReadLine();
    validnumber = int.TryParse(integerInput, out inputNumber);

    if (inputNumber > 10 || inputNumber < 5)
    {
        Console.WriteLine("Please input a valid integer:");
        continue;
    }
    
} while (inputNumber > 10 || inputNumber < 5);

Console.WriteLine($"Your input of '{inputNumber}' has been accepted!");

//------------------------------------------------------------------------

Console.WriteLine("\nInput your role: (Administrator, Manager, User)");
string roleInput = "";
string formattedInput = "";
string chosenRole = "";
do
{
    if (chosenRole == "notValid")
    {
        Console.WriteLine("Please input a valid role:");
    }
    roleInput = Console.ReadLine();
    formattedInput = roleInput.Trim().ToLower();
    switch (formattedInput)
    {
        case "administrator":
            chosenRole = "Administrator";
            break;
        case "manager":
            chosenRole = "Manager";
            break;
        case "user":
            chosenRole = "User";
            break;
        default:
            chosenRole = "notValid";
            break;
    }
} while (chosenRole == "notValid");

Console.WriteLine($"Your role of {chosenRole} has been accepted!\n");

//-------------------------------------------------------------------------

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings)
{
    string[] mySentences = myString.Split('.');
    foreach (string mySentence in mySentences)
    {
        Console.WriteLine(mySentence.Trim());
    }
}


Console.ReadLine();

