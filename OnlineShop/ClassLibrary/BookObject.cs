using System;


namespace OnlineShop;

public class Book : SuperClass
{
    public string? Author;
    public DateTime? DateOfPublish;
    public void Books(string Name, int Price, string Author,DateTime DateOfPublish)
    {
        this.Name = Name;
        this.Price= Price;
        this.Author = Author;
        this.DateOfPublish = DateOfPublish;
    }

}
