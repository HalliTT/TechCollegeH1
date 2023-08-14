using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //Creating list later on to be able to choose and creat account indstead of hard coded value.
        protected static string accounter = "Halli", accountName = "Budget";
        protected static float accountWith, accountDepo, accountBalance;
    }

    class Bank : Account
    {
        /// Withdraw
        /// <summary>
        /// Take value in and if its bigger then balance return Error
        /// else return the new balance after added
        /// </summary>
        /// <param name="value">Float - Value that will be minused from {accountBalance}</param>
        /// <returns>Error(-1) or the new account balance</returns>
        public static float Withdraw(float value)
        {
            if (value > accountBalance)
            {
                return Error(value, accountBalance);
            }

            float newBalance = accountBalance - value;
            accountBalance = newBalance;
            accountWith = accountWith + value;
            return accountBalance;
        }

        /// Deposit
        /// <summary>
        /// Take value in and return the new balance after added
        /// </summary>
        /// <param name="value">Float - Value that will be added to {accountBalance}</param>
        /// <returns>The new account balance</returns>
        public static float Deposit(float value)
        {
            float newBalance = accountBalance + value;
            accountBalance = newBalance;
            accountDepo = accountDepo + value;
            return accountBalance;
        }


        //---- * ALL UNDER * ----//
        //Is only used to write out for console

        /// Error
        /// <summary>
        /// Write a Error message
        /// </summary>
        /// <param name="value">Float - Value that was written by user to withdraw</param>
        /// <param name="balance">Float - accountBalance</param>
        /// <returns>-1</returns>
        public static int Error(float value, float balance)
        {
            Console.WriteLine($"You can not withdraw {value} from your {accountName} ");
            Console.WriteLine($"Because your balance is {accountBalance}");
            return -1;
        }

        /// PrintWelcomeMessage
        /// <summary>
        /// Write a welcome message
        /// </summary>
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine($"Welcome {accounter}");
        }

        /// PrintAccountBalannce
        /// <summary>
        /// Write a message to display accounts and changes
        /// </summary>
        public static void PrintAccountBalannce()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Account Name   |   Deposit   |   Withdrawl   |   Balance");
            Console.WriteLine("---------------------------------------------------------");
            Console.Write($"{accountName}");
            Console.Write(String.Format("{0,10}", "|"));
            Console.Write($"{accountDepo}");
            Console.Write(String.Format("{0,13}", "|"));
            Console.Write($"{accountWith}");
            Console.Write(String.Format("{0,15}", "|"));
            Console.WriteLine($"{accountBalance}");
            Console.WriteLine("---------------------------------------------------------");
        }

        /// PrintNewAccountBalannce
        /// <summary>
        /// Write a message to display balance after changes
        /// </summary>
        public static void PrintNewAccountBalannce()
        {
            Console.WriteLine($"{accountName} new balance is: " + accountBalance);
        }

        /// PrintBalanceForChange
        /// <summary>
        /// Write a message before changes
        /// </summary>
        /// <param name="type">String - if "dep" show deposit else show withdraw</param>
        public static void PrintBalanceForChange(string type)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Your account '{accountName}' balance is: {accountBalance}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Write the amount you want to " );
            Console.WriteLine(type == "dep" ? "Deposit" : "Withdraw");  
         }
    }
}

