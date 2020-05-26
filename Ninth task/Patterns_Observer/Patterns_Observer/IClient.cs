using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Patterns_Observer
{
    interface IClient
    {
        string Name { get; set; }
        int Money { get; set; }

        public void UpdateAccount(IBank bank);

    }
}
