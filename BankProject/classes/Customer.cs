using System.IO.Pipes;

namespace BankCustomer;
public class Customer
{
    public string BankAccountNumber { get; set; }
    public string? FirstName { get; set; }

    public string ? LastName { get; set; }

    public int InitBalance { get; set; }
    public string? EmailAddress { get; set;}

    public string? Address { get; set; } 

    public List<int?> Balance { get; set; } 


    public static List<Customer> GetNewCustomer()
    {
           
        List<Customer> Customers = new List<Customer>();
        do
        
        {
            
            Customer person = new Customer();

            Console.Write("Enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Initial Value: ");
            person.InitBalance = Convert.ToInt32(Console.ReadLine());
            person.Balance = new List<int?>();
            person.Balance.Add(person.InitBalance);

            Console.Write("Enter Bank Account: ");
            person.BankAccountNumber = Console.ReadLine();

            Customers.Add(person);

            Console.Write("Press Y to enter another person, other key to finish.");
            Console.WriteLine();

        } while (Console.ReadKey().Key == ConsoleKey.Y);


        return Customers;
    }

    public static void CalculateBalance(List<Customer> Customers)
    {
        Console.WriteLine("Enter the Bank Account:");
        string? BankAccount = Console.ReadLine();

        Console.WriteLine("Enter the Change Value Amount:");
        int ChangeValue = Convert.ToInt32(Console.ReadLine());


        foreach (var item in Customers)
        {
            if (item.BankAccountNumber == BankAccount)
            {
                item.Balance.Add(ChangeValue + item.Balance.Last());
                Console.WriteLine($"new balance = {item.Balance.Last()}");
            }
        }   
    }

    public static void ShowAllTransactions(List<Customer> Customers)
    {
        Console.WriteLine("Enter the Bank Account:");
        string? BankAccount = Console.ReadLine();

        foreach (var item in Customers)
        {
            if (item.BankAccountNumber == BankAccount)
            {
                for (int i = 0; i < item.Balance.Count; i++)
                {
                    Console.WriteLine($"balance {i} =  {item.Balance[i]}");
                }
                Console.WriteLine($"Final Balance is = {item.Balance.Last()}");
            }
        }
    }

    public static void ShowAllBankAccount(List<Customer> Customers)
    {
        foreach (var item in Customers)
        {
            Console.WriteLine(item.BankAccountNumber);
        }        
    }


}
