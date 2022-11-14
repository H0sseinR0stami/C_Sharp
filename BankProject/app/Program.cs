// See https://aka.ms/new-console-template for more information
using BankCustomer;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

string? choice;
List<Customer> Customers = new List<Customer>();
do

{

Console.WriteLine();
Console.WriteLine("1. Create Bank Account");
Console.WriteLine("2. Change Balance ");
Console.WriteLine("3. Show all Bank Account Numbers");
Console.WriteLine("4. Show all transactions of an Acount");

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
            Customer.ShowAllTransactions(Customers);
            break;


    }

    



    Console.Write("Press C to continue, other key to finish.");
    Console.WriteLine();
}
while(Console.ReadKey().Key == ConsoleKey.C);

