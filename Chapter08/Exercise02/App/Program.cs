using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;


Console.WriteLine("The default regular expression checks for at least one digit.");
string DefaultChars = "^[a-z]+$";

do
{
    Console.WriteLine("Enter a regular expression (or press ENTER to use the default):");
    string? input_re = ReadLine();

    if (string.IsNullOrWhiteSpace(input_re))
    {
        input_re = DefaultChars;
    }
    Regex RegExInput = new Regex(input_re);

    Console.WriteLine("Enter some input: ");
    string? input = ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        input = " ";
    }

    if(RegExInput.IsMatch(input))
        {
        Console.WriteLine($"{input} matches {input_re}? True");
        Console.WriteLine("Press ESC to end or any key to try again");
    }
    else
    {
        Console.WriteLine($"{input} matches {input_re}? False");
        Console.WriteLine("Press ESC to end or any key to try again");
    }
}
while (ReadKey().Key != ConsoleKey.Escape);
