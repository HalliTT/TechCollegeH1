using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ReadKey
    {
        /// TryReadKey
        /// <summary>
        /// Try to parse keyyRead as either int or float depends on variableType
        /// If it does not succe Write error message that can restart program or exit it
        /// </summary>
        /// <param name="keyRead">String - Value of what user has written</param>
        /// <param name="args">String[] - used for load Main()</param>
        /// <param name="variableType">String - ints, floats used to try to parse</param>
        /// <returns>succe: the parseed keyRead</returns>
        public static dynamic TryReadKey(string keyRead, string variableType)
        {
            try
            {
                if(variableType == "ints")
                {
                    return Int32.Parse(keyRead);

                }
                if (variableType == "floats")
                {
                    return float.Parse(keyRead);

                }
            }
            
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine($"i am sorry i dont understand that");
                Console.WriteLine($"press 'any key' to restart -- press 'esc' to exit");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Escape)
                {
                    return null;
                }
                Menu.StartMenu();
            }
            return null;
        }
    }
}
