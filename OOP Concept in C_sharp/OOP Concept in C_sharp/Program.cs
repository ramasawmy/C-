using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region NameSpace Part 1
//using TeamB.GroupA;

////namespace TeamA
////{
////    class Student
////    {
////        public void Display()
////        {

////        }
////    }
////}

//namespace TeamB
//{
//    class student
//    {
//        public void Show()
//        {

//        }
//    }

//    class Teacher
//    {
//        public void GetSalary()
//        {

//        }
//    }

//    namespace GroupA
//    {
//        class Test
//        {
//            public void Go()
//            {
//                System.Console.WriteLine("This is a Go method of class Test which is a Group A namespace of TeamB namespace");
//            }
//        }
//    }
//} 
#endregion

namespace OOP_Concept_in_C_sharp
{
    #region Class & Object Part 1
    //class Customer
    //{
    //    int AcNo;
    //    String Name;
    //    double Bal;

    //    public Customer()
    //    {
    //        Console.WriteLine("Hello Customer");
    //    }

    //    public Customer(int a, String n, double b)
    //    {
    //        AcNo = a;
    //        Name = n;
    //        Bal = b;
    //    }

    //    public void Deposite(double amt)
    //    {
    //        Bal = Bal + amt;
    //    }

    //    public void WthDraw(double amt)
    //    {
    //        Bal = Bal - amt;
    //    }

    //    public void BalEnq()
    //    {
    //        Console.WriteLine("AcNo:{0} Name:{1} Bal:{2}" ,AcNo,Name,Bal);
    //    }
    //} 
    #endregion

    #region Method Overlording part 1
    //class Customer
    //{
    //    int AcNo;
    //    String Name;
    //    double Bal;

    //    public Customer()
    //    {
    //        Console.WriteLine("Hello");
    //    }

    //    public Customer(int a, String n, double b)
    //    {
    //        AcNo = a;
    //        Name = n;
    //        Bal = b;
    //    }

    //    public void Deposite(double amt)
    //    {
    //        Bal = Bal + amt;
    //    }

    //    public void WithDarw(double amt)
    //    {
    //        Bal = Bal - amt;
    //    }

    //    public void BalEnq()
    //    {
    //        Console.WriteLine("AcNo:{0} Name:{1} Bal:{2}" ,AcNo,Name,Bal);
    //    }

    //    public void BalEnq(double amt, String f)
    //    {
    //        if (f == "D") 
    //        {
    //            Bal += amt;
    //        }
    //        else if (f == "w")
    //        {
    //            Bal -= amt;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid Flag");
    //        }

    //        Console.WriteLine("AcNo:{0} Name:{1} Bal:{2}", AcNo,Name,Bal);
    //    }

    //} 
    #endregion

    #region This Key Word Part 1
    //class Customer
    //{
    //    int AcNo;
    //    String Name;
    //    double Bal;
    //    String Contact;

    //    public Customer()
    //    {
    //        Console.WriteLine("Hello");
    //    }

    //    public Customer(int AcNo, String Name, double Bal):this()
    //    {
    //        this.AcNo = AcNo;
    //        this.Name = Name;
    //        this.Bal = Bal;
    //    }

    //    public Customer(int AcNo, String Name, double Bal, String Contact) : this(AcNo,Name,Bal)
    //    {
    //        this.Contact = Contact;
    //    }

    //    public void Deposite(double amt)
    //    {
    //        Bal = Bal + amt;
    //    }

    //    public void WithDarw(double amt)
    //    {
    //        Bal = Bal - amt;
    //    }

    //    public void BalEnq()
    //    {
    //        Console.WriteLine("AcNo:{0} Name:{1} Bal:{2} Contact:{3}", AcNo, Name, Bal, Contact);
    //    }

    //    public void BalEnq(double amt, String f)
    //    {
    //        if (f == "D")
    //        {
    //            Bal += amt;
    //        }
    //        else if (f == "w")
    //        {
    //            Bal -= amt;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid Flag");
    //        }

    //        Console.WriteLine("AcNo:{0} Name:{1} Bal:{2} Contact:{3}", AcNo, Name, Bal, Contact);
    //    }

    //} 
    #endregion

    #region Static variable Part 1
    //class HouseLoan
    //{
    //    int AcNo;
    //    String Name;
    //    double LoanAmount;
    //    static double ROI;

    //    static HouseLoan()
    //    {
    //        ROI = 12.8;
    //    }

    //    public HouseLoan (int AcNo, String Name, double LoanAmount)
    //    {
    //        this.AcNo = AcNo;
    //        this.Name = Name;
    //        this.LoanAmount = LoanAmount;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("AcNo:{0} Name:{1} LoanAmount:{2} ROI:{3}", AcNo, Name, LoanAmount, ROI);
    //        Console.WriteLine("Repay Amount:" + (LoanAmount+(LoanAmount*ROI)/100));
    //    }
    //} 
    #endregion

    #region Static Method Part 1
    //class HouseLoan
    //{
    //    int AcNo;
    //    String Name;
    //    double LoanAmount;
    //    static double ROI;

    //    static HouseLoan()
    //    {
    //        ROI = 12.8;
    //    }

    //    public HouseLoan(int AcNo, String Name, double LoanAmount)
    //    {
    //        this.AcNo = AcNo;
    //        this.Name = Name;
    //        this.LoanAmount = LoanAmount;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("AcNo:{0} Name:{1} LoanAmount:{2} ROI:{3}", AcNo, Name, LoanAmount, ROI);
    //        Console.WriteLine("Repay Amount:" + (LoanAmount + (LoanAmount * ROI) / 100));
    //    }

    //    public static void Enq(double amt, int months) 
    //    {
    //        double repayAmpunt = amt + (amt * ROI) / 100;
    //        Console.WriteLine("Loan Amount:{0} ROI:{1] RepayAmount:{2} EMI:{3} For {4} months", amt, ROI, repayAmpunt, repayAmpunt / months, months);
    //    }
    //} 
    #endregion

 
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Class & Object Part 2
            //Customer c = new Customer(1234, "Jack", 78000);



            //c.BalEnq();

            //c.Deposite(3000);

            //c.BalEnq();

            //c.WthDraw(5000);

            //c.BalEnq();

            //Console.ReadLine(); 
            #endregion

            #region Method Overloading Part 2
            //Customer c = new Customer(1234, "Jack", 78000);

            //c.BalEnq();

            //c.Deposite(3000);
            //c.BalEnq();

            //c.WithDarw(5000);
            //c.BalEnq();

            //c.BalEnq(4500, "D");


            //Console.ReadLine(); 
            #endregion

            #region This Key Word Part 2
            //Customer c = new Customer(123, "Jack", 78000, "987654231");

            //c.BalEnq();

            //Customer c1 = new Customer(123, "Peter", 89000);

            //c.BalEnq();

            //Console.ReadLine();  
            #endregion

            #region Static Variable Part 2
            ////HouseLoan.ROI = 12.8;

            //HouseLoan h = new HouseLoan(123, "Peter", 56000);
            //h.Display();

            //HouseLoan h1 = new HouseLoan(1242, "Jack", 78000);
            //h.Display();

            ////HouseLoan.ROI = 13.8;

            //h1.Display();
            //h.Display();


            //Console.ReadLine(); 
            #endregion

            #region Static Methos Part 2
            ////HouseLoan.ROI = 12.8;

            //HouseLoan h = new HouseLoan(123, "Peter", 56000);
            //h.Display();

            //HouseLoan h1 = new HouseLoan(124, "Jack", 78000);
            //h.Display();

            ////HouseLoan.ROI = 13.8;

            //h1.Display();
            //h.Display();

            //HouseLoan.Enq(68000, 12);

            //Console.ReadLine(); 
            #endregion

            #region NameSpace Part 2
            ////TeamA.Student s = new TeamA.Student();

            ////TeamB.student s1 = new TeamB.student();

            ////s.Display();
            ////s1.Show();

            ////TeamB.GroupA.Test t = new TeamB.GroupA.Test();

            //Test t = new Test();

            //t.Go();

            //System.Console.ReadLine(); 
            #endregion
        }
    }
}
