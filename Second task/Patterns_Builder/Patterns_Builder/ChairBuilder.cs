using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class ChairBuilder : IBuilder
    {
        private Furniture chair = new Furniture();

        public ChairBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Возврат завершенного стула
        /// </summary>
        /// <returns></returns>
        public Furniture GetChair()
        {
            Furniture FinishedChair = chair;
            this.Reset();
            return FinishedChair;
        }

        /// <summary>
        /// Обновление объекта строителя для дальнейших сборок
        /// </summary>
        public void Reset()
        {
            chair = new Furniture();
        }

        /// <summary>
        /// Установка ножек стула
        /// </summary>
        public void SetupLegs()
        {
            chair.Add("Установка ножек стула");
        }

        /// <summary>
        /// Установка основания стула (седушка)
        /// </summary>
        public void SetupBase()
        {
            chair.Add("Установка основания стула");
        }

        /// <summary>
        /// Затягивание винтов
        /// </summary>
        public void TightenTheScrews()
        {
            chair.Add("Затягивание винтов");
        }

        /// <summary>
        /// Установка спинки стула
        /// </summary>
        public void SetupSpecificDetail()
        {
            chair.Add("Установка спинки стула");
        }

        /// <summary>
        /// Вывод названия мебели
        /// </summary>
        public void FurnitureName()
        {
            Console.WriteLine("Стул:");
        }
    }
}
