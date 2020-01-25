using System;
using System.Collections.Generic;
using System.Text;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;


namespace Patterns_AbstractFactory_Loner.AbstractFactory.Classes
{
    class HomeShelf : IShelf
    {
        private string name;

        private HomeShelf()
        {
            name = "Домашний стеллаж";
        }

        private static HomeShelf Element;

        public static HomeShelf GetElement()
        {
            if(Element == null)
            {
                Element = new HomeShelf();
            }
            return Element;
        }

        public string WriteName()
        {
            return name;
        }

        public void WriteNameConsole()
        {
            Console.WriteLine(name);
        }
    }

    class HomeCloset : ICloset
    {
        private string name;

        private HomeCloset()
        {
            name = "Домашний шкаф";
        }

        private static HomeCloset Element;

        public static HomeCloset GetElement()
        {
            if (Element == null)
            {
                Element = new HomeCloset();
            }
            return Element;
        }

        public string WriteName()
        {
            return name;
        }

        public void WriteNameConsole()
        {
            Console.WriteLine(name);
        }
    }
    class HomeChair : IChair
    {
        private string name;

        private HomeChair()
        {
            name = "Домашний стул";
        }

        private static HomeChair Element;

        public static HomeChair GetElement()
        {
            if (Element == null)
            {
                Element = new HomeChair();
            }
            return Element;
        }

        public string WriteName()
        {
            return name;
        }

        public void WriteNameConsole()
        {
            Console.WriteLine(name);
        }
    }

    class HomeStool : IStool
    {
        private string name;

        private HomeStool()
        {
            name = "Домашний табурет";
        }

        private static HomeStool Element;

        public static HomeStool GetElement()
        {
            if (Element == null)
            {
                Element = new HomeStool();
            }
            return Element;
        }

        public string WriteName()
        {
            return name;
        }

        public void WriteNameConsole()
        {
            Console.WriteLine(name);
        }
    }

    class HomeTable : ITable
    {
        private string name;

        private HomeTable()
        {
            name = "Домашний стол";
        }

        private static HomeTable Element;

        public static HomeTable GetElement()
        {
            if (Element == null)
            {
                Element = new HomeTable();
            }
            return Element;
        }

        public string WriteName()
        {
            return name;
        }

        public void WriteNameConsole()
        {
            Console.WriteLine(name);
        }
    }
}
