using static System.Console;

using OnlineShop;




SuperClass.Greeting();

SuperClass.ListOfGoods();

switch (ReadLine())
{
    case "1":

        //list of books
        List<Book> BookList = new List<Book>
        {
            new Book { Name="Anna Karenina", Price = 50, Author = "Leo Tolstoy", DateOfPublish = new(1878, 01, 01) },
            new Book { Name="Gone with the Wind", Price = 40, Author = "Margaret Mitchell", DateOfPublish = new(1936, 01, 01) },
            new Book { Name="White Fang", Price = 30, Author = "Jack London", DateOfPublish = new(1906, 01, 01) }
        };

        WriteLine("List of available books are:");
        for(int i = 0; i < BookList.Count; i++)
        {
            WriteLine($"{i+1}. {BookList[i].Name}");
        }

        switch (ReadLine())
        {
            case "1":
                BookList[0].PrintCongrad();
                break;
            case "2":
                BookList[1].PrintCongrad();
                break;
            case "3":
                BookList[3].PrintCongrad();
                break;
        }
        break;


    case "2":

        //Electronic Devices
        List<ElectronicDevice> ElectronicDevicesList = new List<ElectronicDevice>
        {
            new ElectronicDevice {Name = "Camera", Price = 550 , Color = "Sony" , Company = "Blue" },
            new ElectronicDevice {Name = "Ipad", Price = 1500 , Color = "Apple" , Company = "Silver" },
            new ElectronicDevice {Name = "Mobile Phone", Price = 50 , Color = "Samsung" , Company ="Black" }
        };

        WriteLine("List of available Electronic Devices are:");
        for (int i = 0; i < ElectronicDevicesList.Count; i++)
        {
            WriteLine($"{i + 1}. {ElectronicDevicesList[i].Name}");
        }

        switch (ReadLine())
        {
            case "1":
                ElectronicDevicesList[0].PrintCongrad();
                break;
            case "2":
                ElectronicDevicesList[1].PrintCongrad();
                break;
            case "3":
                ElectronicDevicesList[2].PrintCongrad();
                break;
        }
        break;
    case "3":

        //Clothes
        List<Cloth> ClothList = new List<Cloth>
        {
            new Cloth {Name = "Pants", Price = 70 , Color = "Adidas" , Company = "Green" },
            new Cloth {Name = "Socks", Price = 10 , Color = "D&G" , Company = "Grey" },
            new Cloth {Name = "Shoes", Price = 50 , Color = "Under Armor" , Company ="White" }
        };

        WriteLine("List of available Clothes are:");
        for (int i = 0; i < ClothList.Count; i++)
        {
            WriteLine($"{i + 1}. {ClothList[i].Name}");
        }

        switch (ReadLine())
        {
            case "1":
                ClothList[0].PrintCongrad();
                break;
            case "2":
                ClothList[1].PrintCongrad();
                break;
            case "3":
                ClothList[2].PrintCongrad();
                break;
        }
        break;
}








