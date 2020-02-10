using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Composite
{
    class Worker : Manager
    {
        public Worker(string FIO, string position = "Рабочий") : base(FIO, position)
        {

        }

        public override string Task()
        {
            Random rand = new Random();
            return ReturnData() + ": выполняет задачу №" + rand.Next(1,100);
        }
    }
}
