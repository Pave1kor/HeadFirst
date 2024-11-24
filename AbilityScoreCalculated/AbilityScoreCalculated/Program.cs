using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreCalculated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quite, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }

        }

        private static int ReadInt(int rollResult, string v)
        {
            Console.WriteLine(v + " [" + rollResult + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.Write(" using default value " + rollResult);
                return rollResult;
            }
        }

        private static double ReadDouble(double rollResult, string v)
        {
            Console.WriteLine(v + " [" + rollResult + "]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.Write(" using default value " + rollResult);
                return rollResult;
            }
        }

        internal class AbilityScoreCalculator
        {
            public int RollResult = 14;
            public double DivideBy = 1.75;
            public int AddAmount = 2;
            public int Minimum = 3;
            public int Score;

            public void CalculateAbilityScore()
            {
                double divided = RollResult / DivideBy;
                divided += AddAmount;
                int added = (int)Math.Round(divided);
                if (added < Minimum)
                    Score = Minimum;
                else
                    Score = added;

            }
        }
    }
}
