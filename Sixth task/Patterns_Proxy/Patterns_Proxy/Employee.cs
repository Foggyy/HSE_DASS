using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Proxy
{
    class Employee : GetPersonalData
    {
        string FIO;
        string gender;
        int height;
        int weight;
        string telephone;
        int salary;
        int bonuses;

        public Employee()
        {
            FIO = "Нет данных";
            gender = "Нет данных";
            height = 0;
            weight = 0;
            telephone = "Нет данных";
            salary = 0;
            bonuses = 0;
        }

        public Employee(string FIO, string gender, int height, int weight, string telephone, int salary, int bonuses)
        {
            this.FIO = FIO;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.telephone = telephone;
            this.salary = salary;
            this.bonuses = bonuses;
        }


        public Employee GetEmployeeData()
        {
            return this;
        }

        public void OutputEmployeeData()
        {
            Console.WriteLine("ФИО: " + FIO);
            Console.WriteLine("Пол: " + gender);
            Console.WriteLine("Рост: " + height);
            Console.WriteLine("Вес: " + weight);
            Console.WriteLine("Номер телефона: " + telephone);
        }

        public int GetSalaryData()
        {
            return salary + bonuses;
        }
    
    }
}
