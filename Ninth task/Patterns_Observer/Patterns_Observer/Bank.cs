using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Observer
{

    /// <summary>
    /// Банк, оповещающий клиентов о изменениях на счетах
    /// </summary>
    class Bank : IBank
    {
        public int State { get; set; } = 0;
        private List<IClient> Clients = new List<IClient>();

        public void AddClient(IClient client)
        {
            Clients.Add(client);
            Console.WriteLine("Новый клиент банка: " + client.Name);
        }

        public void NotifyClient()
        {
            foreach (var client in Clients)
            {
                client.UpdateAccount(this);
            }
        }

        public void RemoveClient(IClient client)
        {
            Clients.Remove(client);
            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Клиент " + client.Name + " закрыл счет.");
        }

        public void BankEvents()
        {
            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("Обновление данных банка и оповещение клиентов...");
            this.State = new Random().Next(0, 5);
            this.NotifyClient();
        }
    }
}
