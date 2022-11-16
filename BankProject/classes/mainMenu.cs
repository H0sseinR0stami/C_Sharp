using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer;

    public static class mainMenu
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("please select a number from the list below:");
            Console.WriteLine("1. Create Bank Account");
            Console.WriteLine("2. Change Balance ");
            Console.WriteLine("3. Show all Bank Account Numbers");
            Console.WriteLine("4. Show N transactions of an Acount");
        }
    }

