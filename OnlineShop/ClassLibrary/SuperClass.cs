namespace OnlineShop;
using static System.Console;

public class SuperClass : Object
{
    public string? Name;
    public int? Price;

    public void PrintCongrad()
    {
        WriteLine($"Congratulation! You have bought '{Name}' at price of {Price:c} from our shop.");
        WriteLine();
        WriteLine();
        WriteLine($"Press any key to continue");
        ReadLine();
    }
}
