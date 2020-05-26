using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Observer
{
    /// <summary>
    /// Второй клиент банка
    /// </summary>
    class SecondClient : IClient
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public SecondClient(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void UpdateAccount(IBank bank)
        {
            if ((bank as Bank).State <= 3)
            {
                int sum = new Random().Next(100, 1000);
                Console.WriteLine("\n" + Name + " на ваш счет зачислено " + sum + " у.е.");
                Money = Money + sum;
                Console.WriteLine("Состояние счета " + Name + ": " + Money);
            }
        }
    }
}
