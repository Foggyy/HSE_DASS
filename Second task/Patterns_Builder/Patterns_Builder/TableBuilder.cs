using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class TableBuilder : IBuilder
    {
        private Furniture table = new Furniture();

        public TableBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Возврат завершенного стола
        /// </summary>
        /// <returns></returns>
        public Furniture GetTable()
        {
            Furniture FinishedTable = table;
            this.Reset();
            return FinishedTable;
        }

        /// <summary>
        /// Обновление объекта строителя для дальнейших сборок
        /// </summary>
        public void Reset()
        {
            table = new Furniture();
        }

        /// <summary>
        /// Установка ножек стола
        /// </summary>
        public void SetupLegs()
        {
            table.Add("Установка ножек стола");
        }

        /// <summary>
        /// Установка столешницы
        /// </summary>
        public void SetupBase()
        {
            table.Add("Установка столешницы");
        }

        /// <summary>
        /// Затягивание винтов
        /// </summary>
        public void TightenTheScrews()
        {
            table.Add("Затягивание винтов");
        }

        /// <summary>
        /// Установка ребер поддержки
        /// </summary>
        public void SetupSpecificDetail()
        {
            table.Add("Установка ребер поддержки");
        }

        /// <summary>
        /// Вывод названия мебели
        /// </summary>
        public void FurnitureName()
        {
            Console.WriteLine("Стол:");
        }
    }
}
