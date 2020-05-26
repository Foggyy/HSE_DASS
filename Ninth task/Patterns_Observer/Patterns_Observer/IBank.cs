using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Observer
{
    interface IBank
    {
        public void AddClient(IClient client);
        public void RemoveClient(IClient client);
        public void NotifyClient();
    }
}
