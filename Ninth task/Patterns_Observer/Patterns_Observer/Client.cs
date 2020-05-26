using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Observer
{
    /// <summary>
    /// Первый клиент банка
    /// </summary>
    class Client : IClient
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public Client(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void UpdateAccount(IBank bank)
        {
            if((bank as Bank).State >= 3)
            {
                int sum = new Random().Next(100, 1000);
                Console.WriteLine("\n" + Name + " с вашего счета списано " + sum + " у.е.");
                Money = Money - sum;
                Console.WriteLine("Состояние счета " + Name + ": " + Money);
            }
        }
    }
}
