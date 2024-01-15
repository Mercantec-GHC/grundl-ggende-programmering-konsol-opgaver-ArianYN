////-------------------------------------------------------------
//// Write your first code 
//Console.Write("Congratulations!");
//Console.Write(" ");
//Console.Write("You wrote your first lines of code");
////-------------------------------------------------------------

////-------------------------------------------------------------
////Write code to display the following output: 
//// This is the first line.
//// This is the second line.
//Console.WriteLine("\nThis is the first line.");
//Console.WriteLine("This is the second line.\n");
////-------------------------------------------------------------

////-------------------------------------------------------------
//// Print literal values 
//Console.WriteLine('b');

//Console.WriteLine(123);
//Console.WriteLine(0.25F);
//Console.WriteLine(2.625);
//Console.WriteLine(12.39816m);

//Console.WriteLine(true);
//Console.WriteLine(false);
//Console.WriteLine(" ");
//// -------------------------------------------------------------

////-------------------------------------------------------------
//// Declare variables
//string firstName;
//char userOption;
//int gameScore;
//decimal particlesPerMillion;
//bool processedCustomer;

//firstName = "Bob";
//Console.WriteLine(firstName);
//firstName = "Liem";
//Console.WriteLine(firstName);
//firstName = "Isabella";
//Console.WriteLine(firstName);
//firstName = "Yasmin";
//Console.WriteLine(firstName);
////-------------------------------------------------------------

////-------------------------------------------------------------
//// Declare Implicitly typed local variables
//var message = "Hello World!";

//// Store the following values in variables
//string name = "Bob";
//int messages = 3;
//double temperature = 34.4;

//// 2 different ways of printing the same statement. Bottom is easier read and write
//Console.WriteLine("\nHello, " + name + "!" + " You have " + messages + " messages in your inbox. The temperature is " + temperature + " celsius" );
//Console.WriteLine($"Hello, {name}! You have {message} messages in your inbox. The temperature is {temperature} celsius");
//-------------------------------------------------------------

//-------------------------------------------------------------
//Format literal strings
//Console.WriteLine("\nHello\nWorld!");
//Console.WriteLine("Hello\tWorld!");
//Console.WriteLine("Hello \"World\"!");
//Console.WriteLine("c:\\source\\repos");
//Console.WriteLine(" ");

//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");
//Console.WriteLine(@"c:\invoices");
//Console.WriteLine(" ");

//// This becomes questions marks because Windows CLI doesn't understand all unicode characters
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t"); 
//Console.WriteLine(@"c:\invoices\app.exe -j");

//Console.WriteLine(@"    c:\source\repos
//        (this is where your code goes");

////Combine string using string concatenation
//Console.WriteLine("");
//string firstName = "Bob";
//string message = "Hello " + firstName;
//string greeting = "Hello";
//Console.WriteLine(message);
//Console.WriteLine(greeting + " " + firstName + "!");

//string message1 = $"{greeting} {firstName}!";
//string message2 = $"Hello {firstName}!";
//Console.WriteLine(message2);

//int version = 11;
//string updateText = "Update to Windows";
//string message3 = $"{updateText} {version}";
//Console.WriteLine(message3);
//Console.WriteLine($"{updateText} {version}!");

//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt");

Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt");



Console.ReadLine();
