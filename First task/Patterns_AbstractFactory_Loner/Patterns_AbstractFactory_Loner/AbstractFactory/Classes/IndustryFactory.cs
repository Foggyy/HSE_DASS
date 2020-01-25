using System;
using System.Collections.Generic;
using System.Text;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;


namespace Patterns_AbstractFactory_Loner.AbstractFactory.Classes
{
    class IndustryFactory : IAbstractFactory
    {
        public string FactoryName()
        {
            return "Промышленная";
        }
        public IChair CreateChair()
        {
            return IndustryChair.GetElement();
        }

        public ICloset CreateCloset()
        {
            return IndustryCloset.GetElement();
        }

        public ITable CreateTable()
        {
            return IndustryTable.GetElement();
        }

        public IShelf CreateShelf()
        {
            return IndustryShelf.GetElement();
        }

        public IStool CreateStool()
        {
            return IndustryStool.GetElement();
        }
    }
}
