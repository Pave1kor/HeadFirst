using System;

namespace ПередачаДенег
{
    internal class Guy
    {
        public string Name;
        public int Cash;
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + "has" + Cash + " bucks.");

        }
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "I don't have enought cash to gve you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + "sayse: " + amount + "isn't an amount I'LL take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
