using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankProgram
    {
        /// MyBankPprogram
        /// <summary>
        /// Depending on what user choose go through the switch
        /// </summary>
        /// <param name="menu">Object - Value of what user has written used for switch</param>
        public static void MyBankPprogram(object menu)
        {
            switch (menu)
            {
                //Account info
                case 1:
                    //Print
                    Bank.PrintAccountBalannce();

                    //Start over
                    Console.ReadKey();
                    Menu.StartMenu();
                    break;

                //Deposit
                case 2:
                    //Print
                    Bank.PrintBalanceForChange("dep");
                    Console.Write(">");

                    //Read
                    string writtenDepAmount = Console.ReadLine();
                    //Try parse as float
                    float depositAmount = ReadKey.TryReadKey(writtenDepAmount, "floats");

                    Bank.Deposit(depositAmount);

                    //Print
                    Bank.PrintNewAccountBalannce();

                    //Start over
                    Console.ReadKey();
                    Menu.StartMenu();
                    break;

                //Withdrawl
                case 3:
                    //Print
                    Bank.PrintBalanceForChange(null);
                    Console.Write(">");

                    //Read
                    string writtenWithAmount = Console.ReadLine();
                    //Try parse as float
                    float withdrawAmount = ReadKey.TryReadKey(writtenWithAmount, "floats");

                    //If Error restart page
                    float a = Bank.Withdraw(withdrawAmount);
                    if (a == -1)
                    {
                        //Start over
                        Console.ReadKey();
                        Menu.StartMenu();
                    }

                    //Print
                    Bank.PrintNewAccountBalannce();

                    //Start over
                    Console.ReadKey();
                    Menu.StartMenu();
                    break;

                //Exit
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
