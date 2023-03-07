using System;

namespace Datatype
{
    class Program
    {
        public static void PrintVariableInformation(string datatype)
        {
            //Save DataType as string
            string input = datatype;

            //Check if string can convert to int
            int intResult;
            if (int.TryParse(input, out intResult))
            {
                Console.WriteLine($"You entered the integer {intResult}");

                Console.WriteLine("Int Size: " + sizeof(int));

                Console.WriteLine("MinValue: " + int.MinValue);
                Console.WriteLine("MacValue: " + int.MaxValue);

                int intValue = int.MaxValue;
                UInt64 convertedInt = Convert.ToUInt64(intValue);
                //Add 1 because of 0
                UInt64 newInt = convertedInt + convertedInt + 1;

                Console.WriteLine("Value compined: " + newInt);

                return;
            }

            //Check if bool can convert to bool
            bool boolResult;
            if (bool.TryParse(input, out boolResult))
            {
                Console.WriteLine($"You entered the bool {boolResult}");
                return;
            }

            //Check if string can double to double
            double doubleResult;
            if (double.TryParse(input, out doubleResult))
            {
                Console.WriteLine($"You entered the bool {doubleResult}");

                Console.WriteLine("Int Size: " + sizeof(double));

                Console.WriteLine("MinValue: " + double.MinValue);
                Console.WriteLine("MacValue: " + double.MaxValue);

                double doubleValue = double.MaxValue;
                //Add 1 because of 0
                double newDouble = doubleValue + doubleValue + 1;

                Console.WriteLine("Value compined: " + newDouble);

                return;
            }

            //Check if string can convert to char
            char charResult;
            if (char.TryParse(input, out charResult))
            {
                Console.WriteLine($"You entered the char {charResult}");

                Console.WriteLine("Char Size: " + sizeof(char));

                Console.WriteLine("MinValue: " + char.MinValue);
                Console.WriteLine("MacValue: " + char.MaxValue);

                int charValue = char.MaxValue;
                UInt64 convertedChar = Convert.ToUInt64(charValue);
                //Add 1 because of 0
                UInt64 newChar = convertedChar + convertedChar + 1;

                Console.WriteLine("Value compined: " + newChar);

                //long pointerToNumber = Convert.ToInt32(datatype);
                //Console.WriteLine($"Value of the variable: {datatype}");
                //Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");

                return;
            }

            else
            {
                Console.WriteLine($"You entered the string {input}");
                return;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter something:");
            Console.WriteLine("--One character for char e.g: 'g'");
            Console.WriteLine("--Whole number for int e.g: '568'");
            Console.WriteLine("--Decimal number for double e.g: '2,5'");
            Console.WriteLine("--True or false for bool e.g: 'true'");
            Console.WriteLine("--Word or numbers and characters for string e.g: 'Hello'");
            Console.WriteLine("");

            string input = Console.ReadLine();

            PrintVariableInformation(input);

            //Person p = new Person();
            //p.Name = "Frank";
            //Console.WriteLine(p.GetName());


            //Console.WriteLine("--------------------------------------------");

            //int intSize = sizeof(int);
            //int charSize = sizeof(char);
            //int floatSize = sizeof(float);
            //float[] singles = { 1, 678, 2.37E33F, .00415F, 8.9F };
            //int array = Buffer.ByteLength(singles);
            //Console.WriteLine("he");
            ////Console.WriteLine(Buffer.ByteLength(singles));


            //Console.WriteLine("--------------DIAGRAM OF BYTE---------------");
            //Console.WriteLine("         1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20");
            //Console.Write("Int      ");
            //for (int i = 0; i < intSize; i++)
            //{
            //    Console.Write('*');
            //    Console.Write("  ");
            //}
            //Console.WriteLine("");

            //Console.Write("Char     ");
            //for (int i = 0; i < charSize; i++)
            //{
            //    Console.Write('*');
            //    Console.Write("  ");
            //}
            //Console.WriteLine("");

            //Console.Write("Float    ");
            //for (int i = 0; i < floatSize; i++)
            //{
            //    Console.Write('*');
            //    Console.Write("  ");
            //}
            //Console.WriteLine("");
            //Console.Write("Array    ");
            //for (int i = 0; i < array; i++)
            //{
            //    Console.Write('*');
            //    Console.Write("  ");
            //}
            //Console.WriteLine("");

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

            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("------------------ADDRESS-------------------");
            //int numberInt = 27;
            //int pointerToNumber = numberInt;

            //Console.WriteLine($"Value of the variable: {numberInt}");
            //Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");
            //Console.WriteLine("--------------------------------------------");
        }
    }

    class Person
    {
        public string Name;
        public string GetName()
        {
            return Name;
        }
    }
}
