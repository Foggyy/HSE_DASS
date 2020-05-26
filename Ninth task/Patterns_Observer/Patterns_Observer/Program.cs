using System;

namespace Patterns_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Client firstClient = new Client("Арсентьев Виталий Сергеевич", 50000);
            SecondClient secondClient = new SecondClient("Казанцев Андрей Викторович", 20000);
            Bank bank = new Bank();
            bank.AddClient(firstClient);
            bank.AddClient(secondClient);
            bank.BankEvents();                                              //Обновление счетов клиентов
            bank.BankEvents();
            bank.BankEvents();
            bank.BankEvents();
            bank.RemoveClient(firstClient);
            bank.BankEvents();
        }
    }
}
