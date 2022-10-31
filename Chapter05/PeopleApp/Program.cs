using static System.Console;

using Packt.Shared;

Person sam = new()
{
    Name = "Sam Daniel",
    DateOfBirth = new(1987, 04, 15)
};

sam.FavoritIceCream = "Chocolate Fudge";

WriteLine(sam.Greeting);
WriteLine(sam.Origin);
WriteLine(sam.Age);
WriteLine(sam.FavoritIceCream);

sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");


sam.FavoritePrimeNumber = 1;
WriteLine(sam.FavoritePrimeNumber);

sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

object[] passengers =
{
    new FirstClassPassenger {AirMiles = 1_419},
    new FirstClassPassenger {AirMiles = 16_562},
    new BusinessClassPassenger(),
    new CoachClassPassenger {CarryOnKG = 25.7},
    new CoachClassPassenger {CarryOnKG = 0}
};

foreach (object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson Jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};

//Jeff.FirstName = "Jones";
WriteLine($"{Jeff.FirstName}");

ImmutableVehicle car = new()
{
    Brand = "Mazda",
    color = "black",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car
    with
{ color = "Blue" };

WriteLine($"original car color was {car.color}");
WriteLine($"new car color is {repaintedCar.color}");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls Deconstruct method 
WriteLine($"{who} is a {what}.");
