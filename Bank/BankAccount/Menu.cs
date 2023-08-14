using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Menu
    {
        /// StartMenu
        /// <summary>
        /// Display menu and send ti switch in MyBankProgram
        /// </summary>
        public static void StartMenu()
        {
            Console.Clear();
            Bank.PrintWelcomeMessage();
            Console.WriteLine("1. To see account information");
            Console.WriteLine("2. To deposit into your account");
            Console.WriteLine("3. To withdraw from your account");
            Console.Write(">");

            string readMenu = Console.ReadLine();

            //See if it can be parsed as int else Error (File Functions.cs)
            object menu = ReadKey.TryReadKey(readMenu, "ints");

            
            BankProgram.MyBankPprogram(menu);
        }     
    }
}
