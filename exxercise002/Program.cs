using System.Text.RegularExpressions;
using static System.Console;

string defaultRegEx = "^[a-z]+$";
string? input;

do
{

    Console.WriteLine("The default regular expression checks for at least one digit.");
    Console.WriteLine("Enter a regular expression (or press ENTER to use the default):");

input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
{
    input = defaultRegEx;
        Console.WriteLine($"default is: {input}");
}

Regex regEx = new Regex(input);

Console.WriteLine("Enter some input:");

string? word = Console.ReadLine();

if(word is null)
{
    word = " ";
}



    if (regEx.IsMatch(word))
    {
        Console.WriteLine($"{word} matches {input}? True");
        Console.WriteLine("Press ESC to end or any key to try again.");
    }
    else
    {
        Console.WriteLine($"{word} matches {input}? False");
        Console.WriteLine("Press ESC to end or any key to try again.");
    }
}
while (Console.ReadKey().Key != ConsoleKey.Escape);