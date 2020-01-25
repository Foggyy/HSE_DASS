using System;
using Patterns_AbstractFactory_Loner.AbstractFactory.Classes;
using Patterns_AbstractFactory_Loner.AbstractFactory.Interfaces;


namespace Patterns_AbstractFactory_Loner
{
    class Program
    {
        /// <summary>
        /// Создание комплекта мебели
        /// </summary>
        /// <param name="NewFactory">Тип мебели</param>
        static public void CreateFurniture(IAbstractFactory NewFactory)
        {
            Console.WriteLine("Комплект мебели: " + "\"" + NewFactory.FactoryName() + "\"");
            Console.WriteLine("_____________________________\n");

            var NewChair = NewFactory.CreateChair();                                //создание элементов комплекта мебели
            var NewTable = NewFactory.CreateTable();
            var NewStool = NewFactory.CreateStool();
            var NewShelf = NewFactory.CreateShelf();
            var NewCloset = NewFactory.CreateCloset();

            NewChair.WriteNameConsole();                                            //вывод в консоль
            NewTable.WriteNameConsole();
            NewStool.WriteNameConsole();
            NewShelf.WriteNameConsole();
            NewCloset.WriteNameConsole();
            Console.WriteLine("_____________________________");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            var LabKit = new LaboratoryFactory();
            CreateFurniture(LabKit);

            var HomeKit = new HomeFactory();
            CreateFurniture(HomeKit);

            var IndustryKit = new IndustryFactory();
            CreateFurniture(IndustryKit);
        }
    }
}
