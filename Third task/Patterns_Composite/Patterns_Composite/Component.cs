using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Composite
{
    interface IComponent
    {

        public string Task();

        public void Add(IComponent component);

        public void Remove(IComponent component);

        public void Display();

        public string ReturnData();
    }
}
