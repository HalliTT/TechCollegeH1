using System;

namespace BankAccount
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Display menu options
            Console.Clear();
            Bank.PrintWelcomeMessage();
            Console.WriteLine("1. To see account information");
            Console.WriteLine("2. To deposit into your account");
            Console.WriteLine("3. To withdraw from your account");
            Console.Write(">");
            string readMenu = Console.ReadLine();

            //See if it can be parsed as int else Error (File Functions.cs)
            object menu = ReadKey.TryReadKey(readMenu, args, "ints");

            switch (menu)
            {
                //Account info
                case 1:
                    Bank.PrintAccountBalannce();
                    Console.ReadKey();
                    Main(args);
                    break;

                //Deposit
                case 2:
                    //Print
                    Bank.PrintBalanceForChange("dep");
                    Console.Write(">");

                    //Read
                    string writtenDepAmount = Console.ReadLine();
                    //Try parse as float
                    float depositAmount = ReadKey.TryReadKey(writtenDepAmount, args, "floats");

                    Bank.Deposit(depositAmount);

                    //Print
                    Bank.PrintNewAccountBalannce();
                    Console.ReadKey();
                    Main(args);
                    break;

                //Withdrawl
                case 3:
                    //Print
                    Bank.PrintBalanceForChange(null);
                    Console.Write(">");

                    //Read
                    string writtenWithAmount = Console.ReadLine();
                    //Try parse as float
                    float withdrawAmount = ReadKey.TryReadKey(writtenWithAmount, args, "floats");

                    //If Error restart page
                    float a = Bank.Withdraw(withdrawAmount);
                    if (a == -1)
                    {
                        Console.ReadKey();
                        Main(args);
                    }

                    //Print
                    Bank.PrintNewAccountBalannce();
                    Console.ReadKey();
                    Main(args);
                    break;

                //Exit
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
