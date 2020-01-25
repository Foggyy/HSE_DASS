using System;
using System.Collections.Generic;
using System.Text;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;

namespace Patterns_AbstractFactory_Loner.AbstractFactory.Classes
{
    class HomeFactory : IAbstractFactory
    {
        public string FactoryName()
        {
            return "Домашняя";
        }

        public IChair CreateChair()
        {
            return HomeChair.GetElement();
        }

        public ICloset CreateCloset()
        {
            return HomeCloset.GetElement();
        }

        public ITable CreateTable()
        {
            return HomeTable.GetElement();
        }

        public IShelf CreateShelf()
        {
            return HomeShelf.GetElement();
        }

        public IStool CreateStool()
        {
            return HomeStool.GetElement();
        }
    }
}
