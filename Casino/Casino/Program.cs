using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПередачаДенег;

namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "Павел_", Cash = 100};
            Console.WriteLine("Привет "+ player.Name +"! Порог вероятности: "+odds);
            while (player.Cash > 0)
            {
                Console.WriteLine("У " + player.Name +" "+ player.Cash + " рублей");
                while (true) {
                    Console.Write("Введи размер ставки :");
                    string howMatch = Console.ReadLine();
                    if (int.TryParse(howMatch, out int amount)) {
                        if (amount > 0 & amount <= player.Cash)
                        {
                            int pot = amount*2;
                            var str = random.NextDouble();
                            if ( str> odds)
                            {
                                player.Cash +=pot;
                            }
                            else
                            {
                                player.Cash -=amount;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введи число, больше нуля и меньше " + player.Cash);
                        }
                    } else
                    {
                        Console.WriteLine("Введи число!");
                    }
                  
                }
            }
        }
    }
}
