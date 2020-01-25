using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces
{
    interface IAbstractFactory
    {
        string FactoryName();
        IChair CreateChair();
        ICloset CreateCloset();
        IShelf CreateShelf();
        IStool CreateStool();
        ITable CreateTable();
    }
}
