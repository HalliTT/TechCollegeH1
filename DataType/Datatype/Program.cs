using System;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------INT---------------------");
            Console.WriteLine("Int Size: " + sizeof(int));
            
            Console.WriteLine("MinValue: " + int.MinValue);
            Console.WriteLine("MacValue: " + int.MaxValue);

            int intValue = int.MaxValue;
            UInt64 convertedInt = Convert.ToUInt64(intValue);
            //Add 1 because of 0
            UInt64 newInt = convertedInt + convertedInt + 1;

            Console.WriteLine("Value compined: " + newInt);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-----------------INT DIAGRAM-----------------");
            UInt64 startCount = 1000;
            Console.Write("     ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(startCount);
                Console.Write("     ");
                startCount = startCount * 5;
            }
            Console.WriteLine("");
            Console.Write("Int  ");
            string calcNewInt = Convert.ToString(newInt);
            for (int i = 0; i < 10; i++)
            {
                string tests = Convert.ToString(newInt);

                for (int ind = 0; ind < tests.Length; ind++)
                {
                    Console.Write("*");
                }
                Console.Write("     ");
                newInt = newInt / 10;
            }
            Console.WriteLine("");

            Console.WriteLine("---------------------------------------------");

        }
    }
}
