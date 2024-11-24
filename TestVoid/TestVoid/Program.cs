using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myInt;
            //bool myBool = (bool)myInt;
            string myString = "false";
            //myBool=(bool)myString;
            //myString=(string)myInt;
            //myBool = (bool)myByte;
            //myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'X';
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;
            Console.WriteLine(myString);

        }
    }
}
