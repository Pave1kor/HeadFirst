using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПередачаДенег
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy Joe = new Guy() { Cash= 50,Name="Joe"};
            Guy Bob = new Guy() { Cash = 100, Name = "Bob" };
            while (true)
            {
                Joe.WriteMyInfo();
                Bob.WriteMyInfo();
                Console.WriteLine("Enter an amount: ");
                string howMatch = Console.ReadLine();
                if (howMatch=="") return;
               
               if (int.TryParse(howMatch, out int result)) {
                    Console.Write("Who should give the cach:");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cachGive = Joe.GiveCash(result);
                        Bob.ReceiveCash(cachGive);
                    } else if (whichGuy == "Bob")
                    {
                        int CashGive =Bob.GiveCash(result);
                        Joe.ReceiveCash(CashGive);
                    } else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                } else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}
