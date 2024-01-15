//-------------------------------------------------------------
// Write your first code 
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code");
//-------------------------------------------------------------

//-------------------------------------------------------------
//Write code to display the following output: 
// This is the first line.
// This is the second line.
Console.WriteLine("\nThis is the first line.");
Console.WriteLine("This is the second line.");
//-------------------------------------------------------------

//-------------------------------------------------------------
// Print literal values 
Console.WriteLine('b');

Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);

Console.WriteLine(true);
Console.WriteLine(false);
// -------------------------------------------------------------

//-------------------------------------------------------------
// Declare variables
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
//-------------------------------------------------------------

//-------------------------------------------------------------
// Declare Implicitly typed local variables
var message = "Hello World!";

// Store the following values in variables
string name = "Bob";
int messages = 3;
double temperature = 34.4;

// 2 different ways of printing the same statement. Bottom is easier read and write
Console.WriteLine("Hello, " + name + "!" + " You have " + messages + " messages in your inbox. The temperature is " + temperature + " celsius" );
Console.WriteLine($"Hello, {name}! You have {message} messages in your inbox. The temperature is {temperature} celsius");
//-------------------------------------------------------------




Console.ReadLine();
