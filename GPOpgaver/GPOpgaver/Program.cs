using System;
using System.Runtime.InteropServices;

namespace GPOpgaver
{
    class Program
    {

        static void Main(string[] args)
        {
            //Opgave 1 Interchange
            int x = 1, y = 2 ;
            Console.WriteLine("opgave Interchange before change: " + x + " " + y );
            Opgaver.Interchange(ref x, ref y);
            Console.WriteLine("opgave Interchange after change: " + x + " " + y );

            //Opgave 2 InterchangeTriple
            int newX = 1, newY = 2, newZ = 4;
            Console.WriteLine("opgave InterchangeTriple before change: " + newX + " " + newY + " " + newZ );
            Opgaver.InterchangeTriple(ref newX, ref newY, ref newZ);
            Console.WriteLine("opgave InterchangeTriple after change: " + newX + " " + newY + " " + newZ);

            //Opgave 3 IsPalindrome
            Console.WriteLine("opgave IsPalindrome: " + Opgaver.IsPalindrome("norddron"));
            Console.WriteLine("opgave IsPalindrome: " + Opgaver.IsPalindrome("Hello"));

        }
    }
}
