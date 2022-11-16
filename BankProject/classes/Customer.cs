using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;

namespace BankCustomer;
public class Customer
{
    public string? BankAccountNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int InitBalance { get; set; }
    public string? EmailAddress { get; set; }
    public string? Address { get; set; }
    public List<int>? Balance { get; set; }

    //register new customer
    public List<Customer> GetNewCustomer()
    {

        List<Customer> Customers = new List<Customer>();
        do
        {
            Console.Clear();
            Console.WriteLine();
            Customer person = new Customer();
            try
            {
                Console.Write("Enter first name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter last name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Initial Value: ");
                person.InitBalance = Convert.ToInt32(Console.ReadLine());
                person.Balance = new List<int>();
                if (person.InitBalance >= 0)
                {          
                    person.Balance.Add(person.InitBalance);
                }
                else
                {
                    Console.WriteLine("Initial Value is a Valid positive number!");
                    person.Balance.Add(0);
                }


                Console.Write("Enter Bank Account: ");
                person.BankAccountNumber = Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Initial Value is a Valid positive number!");
                LogHandler.Logger($"while adding new customer {e.Message} error has happend");
            }
            Customers.Add(person);
            LogHandler.Logger($"New Customer with Bank Account {person.BankAccountNumber} has been added");

            Console.Write("Press Y to enter another person, other key to finish.");
            Console.WriteLine();

        } while (Console.ReadKey().Key == ConsoleKey.Y);
        return Customers;
    }

    // add and subtract amount 
    public int CalculateBalance(int balance, int ChangeValue)
    {                     
        int result = ChangeValue + balance;
        if (result >= 0)
        {
            LogHandler.Logger($"balance was = {balance} and with diffAmount={ChangeValue}  the new balance={result} ");
        }
            
        return result;
    }

    //show N transaction
    public void ShowNTransactions(int n, List<int> balance )
    {
        int max = balance.Count;
        if (n > max)
        { n = max; }
        for (int i = max - 1; i >= max - n; --i)
        {
            Console.WriteLine($"balance {i} =  {balance[i]}");
        }
        Console.WriteLine($"Changed amount in {n} transactions : {balance.Last() - balance[max - n]}");
    }

    public static void ShowAllBankAccount(List<Customer> Customers)
    {
        try
        {
            Console.Clear();
            Console.WriteLine();
            if (Customers.Count > 0)
            {
                foreach (var item in Customers)
                {
                    Console.WriteLine(item.BankAccountNumber);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No Customer have been Registered yet!");
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.WriteLine("Try again");
            LogHandler.Logger($"while showing all bank accounts {e.Message} error has happend");
        }

    }

}
