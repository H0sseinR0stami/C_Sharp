
using BankCustomer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

static void mainMenu()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("please select a number from the list below:");
    Console.WriteLine("1. Create Bank Account");
    Console.WriteLine("2. Change Balance ");
    Console.WriteLine("3. Show all Bank Account Numbers");
    Console.WriteLine("4. Show N transactions of an Acount");
}
string? choice;
List<Customer> Customers = new List<Customer>();
do

{
    mainMenu();

    choice = Console.ReadLine();


    switch (choice)
    {
        case "1":
            Customers = Customer.GetNewCustomer();
            break;

        case"2":
            Customer.CalculateBalance(Customers); 
            break;

        case "3":
            Customer.ShowAllBankAccount(Customers);
            break;

        case "4":
            Customer.ShowNTransactions(Customers);
            break;


    }

    
    Console.Write("Press b to go to main menu, other key to finish.");
    Console.WriteLine();
}
while(Console.ReadKey().Key == ConsoleKey.B);

