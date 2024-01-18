
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

//using System;

/////* Format and display medicine times */
/////* Format and display medicine times */
//string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
//string[] address;
//bool validLength = false;
//bool validZeroes = false;
//bool validRange = false;

//foreach (string ip in ipv4Input)
//{
//    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//    ValidateLength();
//    ValidateZeroes();
//    ValidateRange();

//    if (validLength && validZeroes && validRange)
//    {
//        Console.WriteLine($"{ip} is a valid IPv4 address");
//    }
//    else
//    {
//        Console.WriteLine($"{ip} is an invalid IPv4 address");
//    }
//}

//void ValidateLength()
//{
//    validLength = address.Length == 4;
//};

//void ValidateZeroes()
//{
//    foreach (string number in address)
//    {
//        if (number.Length > 1 && number.StartsWith("0"))
//        {
//            validZeroes = false;
//            return;
//        }
//    }

//    validZeroes = true;
//}

//void ValidateRange()
//{
//    foreach (string number in address)
//    {
//        int value = int.Parse(number);
//        if (value < 0 || value > 255)
//        {
//            validRange = false;
//            return;
//        }
//    }
//    validRange = true;
//}

//Random random = new Random();
//int luck = random.Next(100);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };

//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

//tellLuck();

//void tellLuck()
//{
//    Console.WriteLine("A fortune teller whispers the following words:");
//    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//    for (int i = 0; i < 4; i++)
//    {
//        Console.Write($"{text[i]} {fortune[i]} ");
//    }
//}

//int[] schedule = { 800, 1200, 1600, 2000 };
//DisplayAdjustedTimes(schedule, 6, -6);

//void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
//{
//    int diff = 0;
//    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//    {
//        Console.WriteLine("Invalid GMT");
//    }
//    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//    {
//        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//    }
//    else
//    {
//        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//    }

//    for (int i = 0; i < times.Length; i++)
//    {
//        int newTime = ((times[i] + diff)) % 2400;
//        Console.WriteLine($"{times[i]} -> {newTime}");
//    }
//}

//string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//RSVP("Rebecca", 1, "none", true);
//RSVP("Nadia", 2, "Nuts", true);
//RSVP("Linh", 2, "none", false);
//RSVP("Tony", 1, "Jackfruit", true);
//RSVP("Noor", 4, "none", false);
//RSVP("Jonte", 2, "Stone fruit", false);
//ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
//{
//    if (inviteOnly)
//    {
//        // search guestList before adding rsvp
//    }

//    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//    count++;

//    if (inviteOnly)
//    {
//        bool found = false;
//        foreach (string guest in guestList)
//        {
//            if (guest.Equals(name))
//            {
//                found = true;
//                break;
//            }
//        }
//        if (!found)
//        {
//            Console.WriteLine($"Sorry, {name} is not on the guest list");
//            return;
//        }
//    }
//}

//void ShowRSVPs()
//{
//    Console.WriteLine("\nTotal RSVPs:");
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}

//string[,] corporate =
//{
//    {"Robert", "Bavin"}, {"Simon", "Bright"},
//    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
//};

//string[,] external =
//{
//    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
//};

//string externalDomain = "hayworth.com";
//string internalDomain = "contoso.com";

//for (int i = 0; i < corporate.GetLength(0); i++)
//{
//    DisplayEmail("corporate", corporate[i,0], corporate[i,1]);
//}

//for (int i = 0; i < external.GetLength(0); i++)
//{
//    DisplayEmail("external", external[i,0], external[i,1]);
//}

//void DisplayEmail(string extOrCorp, string firstName, string lastName)
//{
//    string email = firstName.Substring(0, 2) + lastName;
//    email = email.ToLower();

//    switch (extOrCorp)
//    {
//        case "corporate":
//            Console.WriteLine($"{email}@{internalDomain}");
//            break;
//        case "external":
//            Console.WriteLine($"{email}@{externalDomain}");
//            break;
//    }
//}

//double total = 0;
//double minimumSpend = 30.00;

//double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
//double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

//for (int i = 0; i < items.Length; i++)
//{
//    total += GetDiscountedPrice(i);
//}

//total -= TotalMeetsMinimum() ? 5.00 : 0.00;

//Console.WriteLine($"Total: ${FormatDecimal(total)}");

//double GetDiscountedPrice(int itemIndex)
//{
//    return items[itemIndex] * (1 - discounts[itemIndex]);
//}

//bool TotalMeetsMinimum()
//{
//    return total >= minimumSpend;
//}

//string FormatDecimal(double input)
//{
//    return input.ToString().Substring(0, 5);
//}

//double usd = 23.73;
//int vnd = UsdToVnd(usd);

//Console.WriteLine($"${usd} USD = ${vnd} VND");
//Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

//int UsdToVnd(double usd)
//{
//    int rate = 23500;
//    return (int)(rate * usd);
//}

//double VndToUsd(int vnd)
//{
//    double rate = 23500;
//    return vnd / rate;
//}

//string ReverseWord(string word)
//{
//    string result = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }
//    return result;
//}

//string input = "snake";

//Console.WriteLine(input);
//Console.WriteLine(ReverseWord(input));

//string ReverseSentence(string input)
//{
//    string result = "";
//    string[] words = input.Split(" ");

//    foreach (string word in words)
//    {
//        result += ReverseWord(word) + " ";
//    }

//    return result.Trim();
//}

//string input1 = "there are snakes at the zoo";

//Console.WriteLine(input1);
//Console.WriteLine(ReverseSentence(input1));

//string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

//Console.WriteLine("Is it a palindrome?");
//foreach (string word in words)
//{
//    Console.WriteLine($"{word}: {IsPalindrome(word)}");
//}

//bool IsPalindrome(string word)
//{
//    int start = 0;
//    int end = word.Length - 1;

//    while (start < end)
//    {
//        if (word[start] != word[end])
//        {
//            return false;
//        }
//        start++;
//        end--;
//    }

//    return true;
//}

//int target = 30;
//int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
//int[,] result = TwoCoins(coins, target);

//if (result.Length == 0)
//{
//    Console.WriteLine("No two coins make change");
//}
//else
//{
//    Console.WriteLine("Change found at positions:");
//    for (int i = 0; i < result.GetLength(0); i++)
//    {
//        if (result[i, 0] == -1)
//        {
//            break;
//        }
//        Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//    }
//}

//int[,] TwoCoins(int[] coins, int target)
//{
//    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//    int count = 0;

//    for (int curr = 0; curr < coins.Length; curr++)
//    {
//        for (int next = curr + 1; next < coins.Length; next++)
//        {
//            if (coins[curr] + coins[next] == target)
//            {
//                result[count, 0] = curr;
//                result[count, 1] = next;
//                count++;
//            }
//            if (count == result.GetLength(0))
//            {
//                return result;
//            }
//        }
//    }
//    return (count == 0) ? new int[0, 0] : result;
//}
using System.Reflection.Metadata.Ecma335;
using System.Runtime;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 5);
        var roll = random.Next(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string userInput = Console.ReadLine();
    userInput = userInput.Trim().ToLower();

    if (userInput == "y")
    {
        return true;
    } 
    else
    {
        return false;
    } 
}

string WinOrLose(int roll, int target)
{
    switch (roll.CompareTo(target))
    {
        case 1:
            return "Congratulations! You won.";
        case 0:
            return "You tied!";
        case -1:
            return "Game over. You lost!";
        default:
            return "Something went wrong";
    }
}
Console.ReadLine();