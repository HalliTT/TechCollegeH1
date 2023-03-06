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
            Console.WriteLine("---------------------CHAR--------------------");
            Console.WriteLine("Char Size: " + sizeof(char));

            Console.WriteLine("MinValue: " + char.MinValue);
            Console.WriteLine("MacValue: " + char.MaxValue);

            int charValue = char.MaxValue;
            UInt64 convertedChar = Convert.ToUInt64(charValue);
            //Add 1 because of 0
            UInt64 newChar = convertedChar + convertedChar + 1;

            Console.WriteLine("Value compined: " + newChar);
            Console.WriteLine("--------------------------------------------");

            int intSize = sizeof(int);
            int charSize = sizeof(char);
            int floatSize = sizeof(float);

            Console.WriteLine("--------------DIAGRAM OF BYTE---------------");
            Console.WriteLine("         1 2 3 4 5 6 7 8 9 10 11 12 13 14 15");
            Console.Write("Int      ");
            for (int i = 0; i < intSize; i++)
            {
                Console.Write('*');
                Console.Write(' ');
            }
            Console.WriteLine("");

            Console.Write("Char     ");
            for (int i = 0; i < charSize; i++)
            {
                Console.Write('*');
                Console.Write(' ');
            }
            Console.WriteLine("");

            Console.Write("Float    ");
            for (int i = 0; i < floatSize; i++)
            {
                Console.Write('*');
                Console.Write(' ');
            }
            Console.WriteLine("");

            //OLD
            //Console.Write("Char ");
            //for (int i = 0; i < 10; i++)
            //{
            //    string charLength = Convert.ToString(newChar);

            //    for (int ind = 0; ind < charLength.Length; ind++)
            //    {
            //        Console.Write("*");
            //    }
            //    newChar = newChar / 5;
            //}
            //Console.WriteLine("");

            Console.WriteLine("--------------------------------------------");

        }
    }
}
