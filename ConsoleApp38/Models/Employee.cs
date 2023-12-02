using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38.Models
{
    internal class Employee
    {
        public static Employee employee;
    
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthday { get; }
            public int Salary { get; set; }

            public Employee(string name, string surname, DateTime birthday, int salary)
            {
                Name = name;
                Surname = surname;
                Birthday = birthday;
                Salary = salary;
            }
        public Employee() 
        {
        }
        public static Employee[] Info()
        {
            Employee isci1 = new Employee("Orxan", "Ibrahimzada", new DateTime(2003,12,03), 10000);
            Employee isci2 = new Employee("Nazim", "Gulbaharov", new DateTime(2004, 12, 02), 3000);
            Employee isci3 = new Employee("Fuad", "Adigozelov", new DateTime(1999, 02, 12), 6000);
            Employee[] isci = { isci1, isci2, isci3 };
            return isci;
        } 
        public int MinSalary(DateTime StartDate,DateTime EndDate, int MinSalary) 
        {
            Employee[] IsciInfo = Info();
            int result = 0;
            foreach (Employee isci in Info())
            {
                if (isci.Birthday >= StartDate && isci.Birthday <= EndDate && isci.Salary >= MinSalary)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
