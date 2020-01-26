using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class ClosetBuilder : IBuilder
    {
        private Furniture closet = new Furniture();

        public ClosetBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Возврат завершенного шкафа
        /// </summary>
        /// <returns></returns>
        public Furniture GetCloset()
        {
            Furniture FinishedCloset = closet;
            this.Reset();
            return FinishedCloset;
        }

        /// <summary>
        /// Обновление объекта строителя для дальнейших сборок
        /// </summary>
        public void Reset()
        {
            closet = new Furniture();
        }

        /// <summary>
        /// Установка стенок шкафа
        /// </summary>
        public void SetupLegs()
        {
            closet.Add("Установка стенок шкафа");
        }

        /// <summary>
        /// Установка полок и оснований
        /// </summary>
        public void SetupBase()
        {
            closet.Add("Установка полок и оснований шкафа");
        }

        /// <summary>
        /// Затягивание винтов
        /// </summary>
        public void TightenTheScrews()
        {
            closet.Add("Затягивание винтов");
        }

        /// <summary>
        /// Установка дверцы шкафа
        /// </summary>
        public void SetupSpecificDetail()
        {
            closet.Add("Установка дверцы шкафа");
        }

        /// <summary>
        /// Вывод названия мебели
        /// </summary>
        public void FurnitureName()
        {
            Console.WriteLine("Шкаф:");
        }
    }
}
