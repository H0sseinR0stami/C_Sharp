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
    public static List<Customer> GetNewCustomer()
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
            }
            Customers.Add(person);

            Console.Write("Press Y to enter another person, other key to finish.");
            Console.WriteLine();

        } while (Console.ReadKey().Key == ConsoleKey.Y);
        return Customers;
    }

    // add and subtract amount 
    public static void CalculateBalance(List<Customer> Customers)
    {
        bool NotFound = true;
        if (Customers.Count > 0)
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter the Bank Account:");
                string? BankAccount = Console.ReadLine();
                foreach (var item in Customers)
                {
                    if (item.BankAccountNumber == BankAccount)
                    {
                        NotFound= false;
                        Console.WriteLine("Enter the Change Value Amount:");
                        int ChangeValue = Convert.ToInt32(Console.ReadLine());
                        int result = ChangeValue + item.Balance.Last();
                        if (result >= 0)
                        {
                            item.Balance.Add(result);
                        }
                        else
                        {
                            Console.WriteLine("it is not possible! not enough money!");
                        }
                        
                        Console.WriteLine($"new balance = {item.Balance.Last()}");
                    }

                }
                if (NotFound)
                {
                    Console.WriteLine("Bank Account Not found!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Try again");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("No Customer have been Registered yet!");
        }
    
    }

    //show N transaction
    public static void ShowNTransactions(List<Customer> Customers)
    {
        bool NotFound = true;

        if (Customers.Count > 0)
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter the Bank Account:");
                string? BankAccount = Console.ReadLine();

                foreach (var item in Customers)
                {
                    if (item.BankAccountNumber == BankAccount)
                    {
                        NotFound = false;
                        Console.WriteLine("Enter the Number of Transaction to display:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int max = item.Balance.Count;
                        if (n > max)
                        { n = max; }

                        for (int i = max - 1; i >= max - n; --i)
                        {
                            Console.WriteLine($"balance {i} =  {item.Balance[i]}");
                        }
                        Console.WriteLine($"Changed amount in {n} transactions : {item.Balance.Last() - item.Balance[max - n]}");
                    }
                }
                if(NotFound)
                {
                    Console.WriteLine("Bank Account Not found!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Try again");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("No Customer have been Registered yet!");
        }
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
        }

    }

}
