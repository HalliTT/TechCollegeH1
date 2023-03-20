using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Payment
    {
        public static dynamic NewPayment(Items code, int type)
        {
            double ItemPrice = code.Price;
            int ItemQuantity = code.Quantaty;

            //Cash
            if (type == 1)
            {
                CashPaymeny(ItemPrice, ItemQuantity);
            }
            //Mobile Pay
            if (type == 2)
            {
                Console.WriteLine("Tow");
            }
            return -1;
        }

        private static bool CashPaymeny(double price, int quantity)
        {
            if (quantity != 0)
            {
                double priceCalc = price;
                Console.WriteLine("Enter cash");
                Console.WriteLine("1$ " + "2$ " + "5$ " + "10$ ");
                for (int i = 0; i <= priceCalc;)
                {
                    Console.Write(">");
                    string test = Console.ReadLine();
                    int newTest = int.Parse(test);
                    if (newTest == 1 || newTest == 2 || newTest == 5 || newTest == 10)
                    {
                        priceCalc -= newTest;
                        Console.WriteLine("You have payed: " + newTest.ToString() + "$");
                        if(priceCalc > 0)
                        {
                            Console.WriteLine("left to pay: " + priceCalc + "$");
                        }
                        if (priceCalc < 0)
                        {
                            Console.WriteLine("Your changes: " + priceCalc);
                        }
                    }
                }
            }
            else
            {

            }
            return false;
        }
    }
}
