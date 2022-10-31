using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Packt.Shared;

public partial class Person
{
    public string Origin
    {
        get
        {
            return $"{Name} was born on {HomePlanet}";
        }
    }

    public string Greeting => $"{Name} says 'hello!'";

    public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

    public string FavoritIceCream { get; set; }

    private string favoritePrimaryColor;
    public string FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }
        set
        {
            switch (value.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    favoritePrimaryColor = value;
                    break;
                default:
                    throw new System.ArgumentException(
                      $"{value} is not a primary color. " +
                      "Choose from: red, green, blue.");
            }
        }
    }

    private int favoritePrimeNumber;
    public int FavoritePrimeNumber
    {
        get { return favoritePrimeNumber; }
        set { favoritePrimeNumber = value; }
    }

    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }
}

