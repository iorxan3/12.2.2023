
using ConsoleApp38.Models;

Employee employee = new();
Employee.Info();
Console.WriteLine(employee.MinSalary(new DateTime(2000, 1, 1), new DateTime(2005, 1, 1), 2000));
