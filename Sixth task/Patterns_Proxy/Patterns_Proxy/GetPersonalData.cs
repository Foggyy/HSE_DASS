using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Proxy
{
    interface GetPersonalData
    {
        public Employee GetEmployeeData();
        public void OutputEmployeeData();
        public int GetSalaryData();
    }
}
