using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Proxy
{
    class EmployeeProxy : GetPersonalData
    {
        GetPersonalData RealEmployee;

        public EmployeeProxy()
        {

        }

        public EmployeeProxy(GetPersonalData RealEmployee)
        {
            this.RealEmployee = RealEmployee.GetEmployeeData();
        }

        public Employee GetEmployeeData()
        {
            if(RealEmployee == null)
                RealEmployee = new Employee();

            return RealEmployee.GetEmployeeData();
        }

        public int GetSalaryData()
        {
            if (RealEmployee == null)
                RealEmployee = new Employee();

            return RealEmployee.GetSalaryData();
        }

        public void OutputEmployeeData()
        {
            if (RealEmployee == null)
                RealEmployee = new Employee();
            Console.WriteLine("\nМетод класса EmployeeProxy");  
            RealEmployee.OutputEmployeeData();
        }
    }
}
