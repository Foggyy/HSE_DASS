using System;
using System.Collections.Generic;

namespace Patterns_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director NewDirector = new Director();
            ChairBuilder chairBuilder = new ChairBuilder();
            TableBuilder tableBuilder = new TableBuilder();
            ShelfBuilder shelfBuilder = new ShelfBuilder();
            StoolBuilder stoolBuilder = new StoolBuilder();
            ClosetBuilder closetBuilder = new ClosetBuilder();
            

            NewDirector.Builder = chairBuilder;                                     //Сборка стула
            NewDirector.BuildFurniture();
            chairBuilder.FurnitureName();
            chairBuilder.GetChair().ShowSteps();

            NewDirector.Builder = tableBuilder;                                     //Сборка стола
            NewDirector.BuildFurniture();
            tableBuilder.FurnitureName();
            tableBuilder.GetTable().ShowSteps();

            NewDirector.Builder = shelfBuilder;                                     //Сборка стеллажа
            NewDirector.BuildFurniture();
            shelfBuilder.FurnitureName();
            shelfBuilder.GetShelf().ShowSteps();

            NewDirector.Builder = stoolBuilder;                                     //Сборка табурета
            NewDirector.BuildFurniture();
            stoolBuilder.FurnitureName();
            stoolBuilder.GetStool().ShowSteps();

            NewDirector.Builder = closetBuilder;                                    //Сборка шкафа
            NewDirector.BuildFurniture();
            closetBuilder.FurnitureName();
            closetBuilder.GetCloset().ShowSteps();
        }
    }
}
