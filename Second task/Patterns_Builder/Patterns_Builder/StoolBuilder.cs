using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class StoolBuilder : IBuilder
    {
        private Furniture stool = new Furniture();

        public StoolBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Обновление объекта строителя для дальнейших сборок
        /// </summary>
        public void Reset()
        {
            stool = new Furniture();
        }

        /// <summary>
        /// Возврат завершенного табурета
        /// </summary>
        /// <returns></returns>
        public Furniture GetStool()
        {
            Furniture FinishedStool = stool;
            this.Reset();
            return FinishedStool;
        }

        /// <summary>
        /// Установка ножек табурета
        /// </summary>
        public void SetupLegs()
        {
            stool.Add("Установка ножек табурета");
        }

        /// <summary>
        /// Установка основания (седушки) табурета
        /// </summary>
        public void SetupBase()
        {
            stool.Add("Установка основания табурета");
        }

        /// <summary>
        /// Затягивание винтов
        /// </summary>
        public void TightenTheScrews()
        {
            stool.Add("Затягивание винтов");
        }

        /// <summary>
        /// Установка ребер поддержки
        /// </summary>
        public void SetupSpecificDetail()
        {
            stool.Add("Установка ребер поддержки");
        }

        /// <summary>
        /// Вывод названия мебели
        /// </summary>
        public void FurnitureName()
        {
            Console.WriteLine("Табурет:");
        }
    }
}
