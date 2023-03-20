using System;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fill Automaten
            Automaten.newTest();

            //Print Automaten
            ItemCollection.PrintList();

            //Select Item
            Console.Write(">");
            string codeEnter = Console.ReadLine();
            int newEnterCoode = int.Parse(codeEnter);

            //Save Selected Item
            Items Item = ItemCollection.SelectObject(newEnterCoode);

            //Print Selected Item
            Console.WriteLine("");
            Console.WriteLine("You have selected:");
            Console.Write($"{ItemCollection.PrintObject(Item, "name")} to price of ");
            Console.WriteLine(ItemCollection.PrintObject(Item, "price"));

            //Select Payment
            Console.WriteLine("");
            Console.WriteLine("Select Payment");
            Console.WriteLine("1) Cash");
            Console.WriteLine("2) Mobile Pay");
            Console.WriteLine("3) Choos another option");
            Console.Write(">");
            string paymenyEnter = Console.ReadLine();
            int newPaymenyCoode = int.Parse(paymenyEnter);

            //
            Payment.NewPayment(Item, newPaymenyCoode);

            //

            Console.ReadKey();
        }
    }
}
