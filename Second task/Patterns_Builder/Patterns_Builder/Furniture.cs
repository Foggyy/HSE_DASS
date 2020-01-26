using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Builder
{
    class Furniture
    {
        /// <summary>
        /// Шаги сборки
        /// </summary>
        List<object> BuildSteps = new List<object>();

        /// <summary>
        /// Добавление шага сборки
        /// </summary>
        /// <param name="step"></param>
        public void Add(string step)
        {
            this.BuildSteps.Add(step);
        }

        /// <summary>
        /// Вывод этапов сборки
        /// </summary>
        public void ShowSteps()
        {
            Console.WriteLine("______________________________");
            for(int i = 0; i < BuildSteps.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + BuildSteps[i]);
            }
            Console.WriteLine("______________________________\n");
        }
    }
}
