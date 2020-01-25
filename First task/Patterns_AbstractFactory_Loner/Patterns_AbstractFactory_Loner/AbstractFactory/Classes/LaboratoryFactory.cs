using System;
using System.Collections.Generic;
using System.Text;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;

namespace Patterns_AbstractFactory_Loner.AbstractFactory.Classes
{
    class LaboratoryFactory : IAbstractFactory
    {
        public string FactoryName()
        {
            return "Лабораторная";
        }

        public IChair CreateChair()
        {
            return LabChair.GetElement();
        }

        public ICloset CreateCloset()
        {
            return LabCloset.GetElement();
        }

        public ITable CreateTable()
        {
            return LabTable.GetElement();
        }

        public IShelf CreateShelf()
        {
            return LabShelf.GetElement();
        }

        public IStool CreateStool()
        {
            return LabStool.GetElement();
        }
    }
}
