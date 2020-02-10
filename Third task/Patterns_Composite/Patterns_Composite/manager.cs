using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Composite
{
    class Manager : Director
    {
        protected List<IComponent> workers = new List<IComponent>();
        public Manager(string FIO, string position = "Менеджер") : base(FIO, position)
        {

        }

        public override void Add(IComponent component)
        {
            if(component is Worker)
                workers.Add(component);
        }

        public override void Remove(IComponent component)
        {
            if (component is Worker)
                workers.Remove(component);
        }

        /// <summary>
        /// Вывод работников подчиненных менеджеру
        /// </summary>
        /// <returns></returns>
        public override string Task()
        {
            int count = 1;
            string result = "   Подчиненные:\n";
            foreach (IComponent element in this.workers)
            {
                if (element is Worker)
                {
                    result = result + "    " + count + ") " + element.Task() + "\n";
                    count++;
                }
            }

            return result;
        }
    }
}
