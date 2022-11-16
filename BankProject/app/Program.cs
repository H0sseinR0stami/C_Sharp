
using BankCustomer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;


string? choice;
List<Customer> Customers = new List<Customer>();


do

{
    mainMenu.Menu();
    

    choice = Console.ReadLine();


    switch (choice)
    {


        case "1":
            LogHandler.Logger($"Creating new customer");
            var c1 = new Customer();
            Customers = c1.GetNewCustomer();
            break;


        case"2":
            LogHandler.Logger("new transaction started");
            Customer c2 = new Customer();

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
                            Console.WriteLine("Enter the Change Value Amount:");
                            int ChangeValue = Convert.ToInt32(Console.ReadLine());

                            int result = c2.CalculateBalance(ChangeValue , item.Balance.Last());

                            if (result >= 0)
                            {
                                item.Balance.Add(result);
                            }
                            else
                            {
                                Console.WriteLine("it is not possible! not enough balance!");
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
                    LogHandler.Logger($"while doing transaction {e.Message} error happend");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No Customer have been Registered yet!");
            }         
            break;

        case "3":
            LogHandler.Logger("Showing all bank accounts");
            Customer.ShowAllBankAccount(Customers);           
            break;



        case "4":               
            bool NotFound1 = true;
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
                            NotFound1 = false;
                            Console.WriteLine("Enter the Number of Transaction to display:");
                            int n = Convert.ToInt32(Console.ReadLine());

                            var c3 = new Customer();
                            c3.ShowNTransactions(n,item.Balance);

                            LogHandler.Logger($"Showing last {n} transactions of bank account {item.BankAccountNumber}");
                        }
                    }
                    if (NotFound1)
                    {
                        Console.WriteLine("Bank Account Not found!");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try again");
                    LogHandler.Logger($"while Showing last N transactions  {e.Message} error happend");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No Customer have been Registered yet!");
            }                       
            break;
            

    }

    
    Console.Write("Press b to go to main menu, other key to finish.");
    Console.WriteLine();
}
while(Console.ReadKey().Key == ConsoleKey.B);

