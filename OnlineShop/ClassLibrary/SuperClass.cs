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

    public static void Greeting()
    {
        WriteLine("-------------------------------------------------");
        WriteLine("|              Welcome to our shop!              |");      
        WriteLine("|  Please select a number from the list below    |");
        WriteLine("-------------------------------------------------");
    }

    public static int ListOfGoods()
    {
        string[] Goods = { "Books", "Electronic Devices", "Clothes" };

        for (int i = 0; i < Goods.Length; i++)
        {
            WriteLine($"{i + 1}. {Goods[i]}");
        }
        return Goods.Length;
    }

    public static int GetInput(int max)
    {
        int o = -1;
        var validInput = false;
        Console.WriteLine("Please select a number from the list above ");
        while (!validInput)
        {
            var playerChoice = -1;
           
            int.TryParse(Console.ReadLine(), out playerChoice);
            if (playerChoice > 0 && playerChoice <= max)
            {
                validInput = true;
                o = playerChoice;
            }
            else
            {
                WriteLine();
                WriteLine();
                WriteLine();
                Console.WriteLine($"You have entered '{playerChoice}' which is an invalid choice!");
                Console.WriteLine($"Please select a valid number from 1 to {max}");
                validInput = false;
            }
        }
        return o;

    }

}
