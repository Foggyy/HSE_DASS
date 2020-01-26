using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class ShelfBuilder : IBuilder
    {
        private Furniture shelf = new Furniture();

        public ShelfBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Возврат завершенного стеллажа
        /// </summary>
        /// <returns></returns>
        public Furniture GetShelf()
        {
            Furniture FinishedShelf = shelf;
            this.Reset();
            return FinishedShelf;
        }

        /// <summary>
        /// Обновление объекта строителя для дальнейших сборок
        /// </summary>
        public void Reset()
        {
            shelf = new Furniture();
        }

        /// <summary>
        /// Установка стенок стеллажа
        /// </summary>
        public void SetupLegs()
        {
            shelf.Add("Установка стенок стеллажа");
        }

        /// <summary>
        /// Установка полок и основания стеллажа
        /// </summary>
        public void SetupBase()
        {
            shelf.Add("Установка основания и полок стеллажа");
        }

        /// <summary>
        /// Затягивание винтов
        /// </summary>
        public void TightenTheScrews()
        {
            shelf.Add("Затягивание винтов");
        }

        /// <summary>
        /// Установка перегородок стеллажа
        /// </summary>
        public void SetupSpecificDetail()
        {
            shelf.Add("Установка перегородок стеллажа");
        }

        /// <summary>
        /// Вывод названия мебели
        /// </summary>
        public void FurnitureName()
        {
            Console.WriteLine("Стеллаж:");
        }
    }
}
