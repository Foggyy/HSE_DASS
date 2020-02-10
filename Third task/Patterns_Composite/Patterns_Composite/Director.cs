using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Composite
{
    class Director : IComponent
    {
        string FIO;
        string position;
        protected List<IComponent> managers = new List<IComponent>();
        public Director(string FIO, string position = "Директор")
        {
            this.FIO = FIO;
            this.position = position;
        }

        public virtual void Add(IComponent component)
        {
            managers.Add(component);
        }

        public virtual void Remove(IComponent component)
        {
            managers.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("ФИО: " + FIO);
        }

        public string ReturnData()
        {
            return position + " " + FIO;
        }

        /// <summary>
        /// Вывод всех подчиненных директора и менеджеров
        /// </summary>
        /// <returns></returns>
        public virtual string Task()
        {
            int count = 1;
            string result = "\nПодчиненные директора:\n_____________________________\n";
            foreach(IComponent element in this.managers)
            {
                if(element is Manager)
                {
                    result = result + count + ") " + element.ReturnData() + "\n";
                    result = result + element.Task() + "\n";
                    count++;
                }
            }

            return result;
        }

    }
}
