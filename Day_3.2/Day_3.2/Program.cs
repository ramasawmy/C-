using System;
using MyOrg.HR;

//namespace Admin
//{
//    class Employee
//    {
//        public void Add() { }
//        public void Update() { }
//    }
//}

namespace MyOrg
{
    namespace HR
    {
        class Employee
        {
            public void CalculateSalary() { }
            public void CalculateLeave() { }
        }
    }
}

namespace Day_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //admin.employee e1 = new admin.employee();
            //e1.add();
            //e1.update();

            //HR.Employee E2 = new HR.Employee();
            //E2.CalculateSalary();
            //E2.CalculateLeave();

            //MyOrg.HR.Employee E1 = new MyOrg.HR.Employee();
            //E1.CalculateSalary();

            Employee E1 = new Employee();
            E1.CalculateSalary();




            Console.ReadLine();
        }
    }
}
