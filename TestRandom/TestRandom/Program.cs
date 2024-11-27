using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestRandom
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random();
            int randomInt = random.Next(10);
            Console.WriteLine(randomInt);
            int dieRol = random.Next(1,7);
            Console.WriteLine(dieRol);
        }
    }
}
