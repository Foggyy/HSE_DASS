using System;
using System.Collections.Generic;

namespace Patterns_Proxy
{
    class Program
    {
        public static void OutputEmployees(List<GetPersonalData> mas)
        {
            int count = 1;
            foreach(GetPersonalData ProxyEmployee in mas)
            {
                Console.WriteLine("\nПерсональные данные сотрудника " + "№" + count + ":");
                Console.WriteLine("__________________________________");
                ProxyEmployee.OutputEmployeeData();
                Console.WriteLine("Зарплата сотрудника: " + Convert.ToString(ProxyEmployee.GetSalaryData()));
                count++;
            }
        }

        static void Main(string[] args)
        {
            List<GetPersonalData> Employees = new List<GetPersonalData>();
            GetPersonalData RealEmployee = new Employee("Арсентьев Виталий Владимирович","муж.", 180, 86, "89638586478",45000,20000);   //1 сотрудник
            GetPersonalData ProxyEmployee = new EmployeeProxy(RealEmployee);
            Employees.Add(ProxyEmployee);
            RealEmployee = new Employee("Болгов Виктор Андреевич", "муж.", 172, 70, "89504256612", 35000, 7500);                        //2 сотрудник
            ProxyEmployee = new EmployeeProxy(RealEmployee);
            Employees.Add(ProxyEmployee);
            RealEmployee = new Employee("Швецова Татьяна Николаевна", "жен.", 163, 54, "89124587812", 26000, 15000);                    //3 сотрудник
            ProxyEmployee = new EmployeeProxy(RealEmployee);
            Employees.Add(ProxyEmployee);
            OutputEmployees(Employees);                                                     //вывод данных сотрудников
        }
    }
}
