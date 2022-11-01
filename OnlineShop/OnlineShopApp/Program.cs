using static System.Console;

using OnlineShop;
using System.Diagnostics;
using System.Xml.Linq;



 static void Greeting()
{
    WriteLine("-------------------------------------------------");
    WriteLine("|              Welcome to our shop!              |");
    WriteLine("|  Please select a number from the list below    |");
    WriteLine("-------------------------------------------------");
}

static int ListOfGoods()
{
    string[] Goods = { "Books", "Electronic Devices", "Clothes" };

    for (int i = 0; i < Goods.Length; i++)
    {
        WriteLine($"{i + 1}. {Goods[i]}");
    }
    return Goods.Length;
}

static int GetInput(int max)
{
    int OutNumber = -1;
    var validInput = false;
    Console.WriteLine("Please select a number from the list above ");
    while (!validInput)
    {
        var playerChoice = -1;

        int.TryParse(Console.ReadLine(), out playerChoice);
        if (playerChoice > 0 && playerChoice <= max)
        {
            validInput = true;
            OutNumber = playerChoice;
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
    return OutNumber;
}


Greeting();

int NumberOfGoods = ListOfGoods();

int? item = GetInput(NumberOfGoods);
Clear();

switch (item)
{
    case 1:

        //list of books
        List<Book> BookList = new List<Book>
        {
            new Book { Name="Anna Karenina", Price = 50, Author = "Leo Tolstoy", DateOfPublish = new(1878, 01, 01) },
            new Book { Name="Gone with the Wind", Price = 40, Author = "Margaret Mitchell", DateOfPublish = new(1936, 01, 01) },
            new Book { Name="White Fang", Price = 30, Author = "Jack London", DateOfPublish = new(1906, 01, 01) }
        };

        WriteLine(" ------------------------------");
        WriteLine("| List of available books are:  |");
        WriteLine(" ------------------------------");
        for (int i = 0; i < BookList.Count; i++)
        {
            WriteLine($"{i+1}. {BookList[i].Name}");
        }
        WriteLine(" -------------------------------");

        int? choice1 = GetInput(BookList.Count);
        Clear();

        switch (choice1)
        {
            case 1:
                BookList[0].PrintCongrad();
                break;
            case 2:
                BookList[1].PrintCongrad();
                break;
            case 3:
                BookList[2].PrintCongrad();
                break;
        }
        break;


    case 2:

        //Electronic Devices
        List<ElectronicDevice> ElectronicDevicesList = new List<ElectronicDevice>
        {
            new ElectronicDevice {Name = "Camera", Price = 550 , Color = "Sony" , Company = "Blue" },
            new ElectronicDevice {Name = "Ipad", Price = 1500 , Color = "Apple" , Company = "Silver" },
            new ElectronicDevice {Name = "Mobile Phone", Price = 50 , Color = "Samsung" , Company ="Black" }
        };

        WriteLine(" ---------------------------------------------");
        WriteLine("| List of available Electronic Devices are:   |");
        WriteLine(" ---------------------------------------------");
        for (int i = 0; i < ElectronicDevicesList.Count; i++)
        {
            WriteLine($"{i + 1}. {ElectronicDevicesList[i].Name}");
        }
        WriteLine(" ---------------------------------------------");

        int? choice2 = GetInput(ElectronicDevicesList.Count);
        Clear();

        switch (choice2)
        {
            case 1:
                ElectronicDevicesList[0].PrintCongrad();
                break;
            case 2:
                ElectronicDevicesList[1].PrintCongrad();
                break;
            case 3:
                ElectronicDevicesList[2].PrintCongrad();
                break;
        }
        break;
    case 3:

        //Clothes
        List<Cloth> ClothList = new List<Cloth>
        {
            new Cloth {Name = "Pants", Price = 70 , Color = "Adidas" , Company = "Green" },
            new Cloth {Name = "Socks", Price = 10 , Color = "D&G" , Company = "Grey" },
            new Cloth {Name = "Shoes", Price = 50 , Color = "Under Armor" , Company ="White" }
        };

        WriteLine(" --------------------------------");
        WriteLine("| List of available Clothes are: |");
        WriteLine(" --------------------------------");
        for (int i = 0; i < ClothList.Count; i++)
        {
            WriteLine($"{i + 1}. {ClothList[i].Name}");
        }
        WriteLine(" --------------------------------");

        int? choice3 = GetInput(ClothList.Count);
        Clear();

        switch (choice3)
        {
            case 1:
                ClothList[0].PrintCongrad();
                break;
            case 2:
                ClothList[1].PrintCongrad();
                break;
            case 3:
                ClothList[2].PrintCongrad();
                break;
        }
        break;
}








