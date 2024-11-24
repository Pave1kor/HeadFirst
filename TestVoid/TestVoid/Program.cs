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
            for (float f = 10; float.IsInfinity(f); f *= f)
            {
                Console.WriteLine(f);
            }
            for (double f = 10; double.IsInfinity(f); f *= f)
            {
                Console.WriteLine(f);
            }
        }
    }
}
