using System;

namespace Day_4._3
{
    #region Interface
    //interface IBulkOperation
    //{
    //    void DeleteAll();       
    //}
    //interface Ioperations
    //{
    //    void GetAll();
    //    void GetByTD();
    //    void create();
    //    void Update();
    //    void Delete();

    //}

    //class Employee : Ioperations, IBulkOperation
    //{
    //    public void create()
    //    {
    //        Console.WriteLine("Create Employee");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("Delete Employee");
    //    }

    //    public void DeleteAll()
    //    {
    //        Console.WriteLine("Delete All Operation");
    //    }

    //    public void GetAll()
    //    {
    //        Console.WriteLine("Get all Employee");
    //    }

    //    public void GetByTD()
    //    {
    //        Console.WriteLine("Get Employee ID");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Update Employee");
    //    }
    //} 
    #endregion

    partial class A
    {
        public void show()
        {
            Console.WriteLine("show");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            a.show();
            a.Display();

            Console.ReadLine();
        }
    }
}
