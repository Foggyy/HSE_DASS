using System;
using System.Collections.Generic;
using System.Text;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;


namespace Patterns_AbstractFactory_Loner.AbstractFactory.Classes
{
    class LabShelf : IShelf
    {
        private string name;

        private LabShelf()
        {
            name = "Лабораторный стеллаж";
        }

        private static LabShelf Element;

        public static LabShelf GetElement()
        {
            if (Element == null)
            {
                Element = new LabShelf();
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

    class LabCloset : ICloset
    {
        private string name;

        private LabCloset()
        {
            name = "Лабораторный шкаф";
        }

        private static LabCloset Element;

        public static LabCloset GetElement()
        {
            if (Element == null)
            {
                Element = new LabCloset();
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
    class LabChair : IChair
    {
        private string name;

        private LabChair()
        {
            name = "Лабораторный стул";
        }

        private static LabChair Element;

        public static LabChair GetElement()
        {
            if (Element == null)
            {
                Element = new LabChair();
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

    class LabStool: IStool
    {
        private string name;

        private LabStool()
        {
            name = "Лабораторный табурет";
        }

        private static LabStool Element;

        public static LabStool GetElement()
        {
            if (Element == null)
            {
                Element = new LabStool();
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

    class LabTable: ITable
    {
        private string name;

        private LabTable()
        {
            name = "Лабораторный стол";
        }

        private static LabTable Element;

        public static LabTable GetElement()
        {
            if (Element == null)
            {
                Element = new LabTable();
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
