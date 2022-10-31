namespace OnlineShop;
using static System.Console;

public class SuperClass : Object
{
    public string? Name;
    public int? Price;
    public void PrintCongrad()
    {
        WriteLine($"Congratulation! You have bought '{Name}' with price of {Price:c} from our shop.");
    }

    public static void Greeting()
    {
        WriteLine("-------------------------------------------------");
        WriteLine("|              Welcome to our shop!              |");      
        WriteLine("|  Please select a number from the list below    |");
        WriteLine("-------------------------------------------------");
    }

    public static void ListOfGoods()
    {
        string[] Goods = { "Books", "Electronic Devices", "Clothes" };

        for (int i = 0; i < Goods.Length; i++)
        {
            WriteLine($"{i + 1}. {Goods[i]}");
        }

    }

}
