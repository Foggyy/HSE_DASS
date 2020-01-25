using System;
using System.Collections.Generic;
using System.Text;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;


namespace Patterns_AbstractFactory_Loner.AbstractFactory.Classes
{
    class IndustryShelf : IShelf
    {
        private string name;

        private IndustryShelf()
        {
            name = "Промышленный стеллаж";
        }

        private static IndustryShelf Element;

        public static IndustryShelf GetElement()
        {
            if (Element == null)
            {
                Element = new IndustryShelf();
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

    class IndustryCloset : ICloset
    {
        private string name;

        private IndustryCloset()
        {
            name = "Промышленный шкаф";
        }

        private static IndustryCloset Element;

        public static IndustryCloset GetElement()
        {
            if (Element == null)
            {
                Element = new IndustryCloset();
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
    class IndustryChair : IChair
    {
        private string name;

        private IndustryChair()
        {
            name = "Промышленный стул";
        }

        private static IndustryChair Element;

        public static IndustryChair GetElement()
        {
            if (Element == null)
            {
                Element = new IndustryChair();
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

    class IndustryStool : IStool
    {
        private string name;

        private IndustryStool()
        {
            name = "Промышленный табурет";
        }

        private static IndustryStool Element;

        public static IndustryStool GetElement()
        {
            if (Element == null)
            {
                Element = new IndustryStool();
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

    class IndustryTable : ITable
    {
        private string name;

        private IndustryTable()
        {
            name = "Промышленный стол";
        }

        private static IndustryTable Element;

        public static IndustryTable GetElement()
        {
            if (Element == null)
            {
                Element = new IndustryTable();
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
