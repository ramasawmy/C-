using System;
using ClassLibrary1;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee()
            {
                EmpID = 100,
                Name = "Steven",
                SalaryPerDay = 32.5,
                HRA = 12.3,
            };

            double GS = E.GetSalary(3);
            Console.WriteLine("Gross Salary of {0} is {1}", E.Name, GS);
            Console.ReadLine();
        }
    }
}
