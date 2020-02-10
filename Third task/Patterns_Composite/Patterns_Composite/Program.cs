using System;

namespace Patterns_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent Head = new Director("Шапитько Виталий Сергеевич");

            IComponent FirstManager = new Manager("Литвин Арсений Григорьевич");
            IComponent SecondManager = new Manager("Стребков Антон Васильевич");

            Head.Add(FirstManager);
            Head.Add(SecondManager);

            FirstManager.Add(new Worker("Исаев Климент Натанович"));
            FirstManager.Add(new Worker("Корнилов Гордей Феликсович"));
            FirstManager.Add(new Worker("Владимиров Петр Данилович"));

            SecondManager.Add(new Worker("Ковалёв Валерий Александрович"));
            SecondManager.Add(new Worker("Корнилов Матвей Федосеевич"));
            SecondManager.Add(new Worker("Исаков Степан Аркадьевич"));

            Console.WriteLine("Информация о организации:\n");
            Head.Display();
            Console.WriteLine(Head.Task());
        }
    }
}
