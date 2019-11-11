using System;

namespace ClassLibrary1
{
    public class Employee
    {
        public int EmpID { get; set; }
        public String Name { get; set; }
        public double SalaryPerDay { get; set; }
        public double HRA { get; set; }

        public double GetSalary(int NoOfLeaveTaken)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Year;
            int NoOfWorkingDay = DateTime.DaysInMonth(year, month);
            int NoOfDayPresent = NoOfWorkingDay - NoOfLeaveTaken;
            double BasicSalary = NoOfDayPresent * SalaryPerDay;
            double HRASal = BasicSalary * HRA / 100;
            double GrossSalary = BasicSalary + HRASal;
            return GrossSalary;

        }

    }
}
