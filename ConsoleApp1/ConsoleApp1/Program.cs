using System;
#region ConstructorChaining

//class A
//{
//    public A()
//    {
//        Console.WriteLine("Default Constructor of A ");
//    }

//    public A(int a)
//    {
//        Console.WriteLine("Constructor of A with param ");
//    }
//}

//class B:A 
//{
//    public B():base(34)
//    {
//        Console.WriteLine("Default constrcutor of B");
//    }

//    public B(int X)
//    {
//        Console.WriteLine("Constructor of B with param");
//    }
//}

//class C : B
//{
//    public C():base(67)
//    {
//        Console.WriteLine("Default constructor of C");
//    }
//} 
#endregion

#region Override_1
//class Customer
//{
//    public int CustomerID { get; set; }
//    public String Name { get; set; }

//    public virtual void GetDetails()
//    {
//        Console.WriteLine("CustomerID : " + CustomerID);
//        Console.WriteLine("Name : " + Name);
//    }
//}

//class BankCustomer:Customer
//{
//    public double Balance { get; set; }

//    public override void GetDetails()
//    {
//        base.GetDetails();
//        //Console.WriteLine("CustomerID : " + CustomerID);
//        //Console.WriteLine("Name : " + Name);
//        Console.WriteLine("Bal : " + Balance);
//    }

//    public void deposite(double Amount)
//    {
//        Balance += Amount;
//        this.GetDetails();
//    }

//} 
#endregion

namespace ConsoleApp1
{
    #region Inheritance
    //class Customer
    //{
    //    public int CustomerID { get; set; }
    //    public String Name { get; set; }
    //    public String Email { get; set; }

    //    public void Details()
    //    {
    //        Console.WriteLine("CustomerID " + CustomerID);
    //    }
    //}

    //class BankCustomer : Customer
    //{
    //    public int AccountNumber { get; set; }
    //    public double Balance { get; set; }

    //    public void BankCustomerDetails()
    //    {
    //        Console.WriteLine("CustomerID " + CustomerID);
    //        Console.WriteLine("Bal " + Balance);
    //    }
    //}

    //class LoanCustomer : BankCustomer
    //{
    //    public double LoanAmount { get; set; }
    //    public double ROI { get; set; }
    //}

    //public class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        Customer C = new Customer()
    //        {
    //            CustomerID = 123,
    //            Name = "Peter",
    //            Email = "Peter@gmail.com"
    //        };

    //        BankCustomer BC = new BankCustomer()
    //        {
    //            CustomerID = 124,
    //            Name = "Jack",
    //            Email = "Jack@gmail.com",
    //            AccountNumber = 12345,
    //            Balance = 5000
    //        };

    //        BC.Details();
    //        BC.BankCustomerDetails();

    //        C.Details();

    //        LoanCustomer Lc = new LoanCustomer()
    //        {

    //        };
    //    }
    //} 
    #endregion

    #region Chaining
    //class Customer
    //{
    //    protected int CustomerID;
    //    protected String Name;
    //    protected string Email;

    //    public Customer()
    //    {
    //        Console.WriteLine("This is Customer constructor !");
    //    }

    //    public Customer(int CustomerID, String Name, String Email)
    //    {
    //        Console.WriteLine("This is Customer constructor with parameter!");
    //        this.CustomerID = CustomerID;
    //        this.Name = Name;
    //        this.Email = Email;
    //    }

    //}

    //class BankCustomer : Customer
    //{
    //    protected int AcNo;
    //    protected double Balance;

    //    public BankCustomer()
    //    {
    //        Console.WriteLine("This is Bank Customer constructor !");
    //    }

    //    public BankCustomer(int CustomerID, String Name, String Email, int AcNo, double Balance)
    //        :base(CustomerID, Name, Email)
    //    {
    //        Console.WriteLine("This is Bank Customer constructor with parameter !");
    //        //this.CustomerID = CustomerID;
    //        //this.Name = Name;
    //        //this.Email = Email;
    //        this.AcNo = AcNo;
    //        this.Balance = Balance;
    //    }

    //}


    //public class Program
    //{
    //    static void Main(String[] args)
    //    {

    //        var BC = new BankCustomer(123, "Peter", "zzzzzz", 7678, 5000);

    //    }
    //} 
    #endregion

    #region Sealed
    //class A
    //{
    //    public virtual void show()
    //    {
    //        Console.WriteLine("Show of A");
    //    }
    //}

    //class B:A
    //{
    //    public override sealed void show()
    //    {
    //        Console.WriteLine("Show of B");
    //    }
    //}

    //sealed class C:B
    //{
    //    //public override void show()
    //    //{
    //    //    Console.WriteLine("Show of C");
    //    //}
    //}

    //class D
    //{

    //} 
    #endregion

    #region Abstact
    //abstract class A
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("This is show of A");
    //    }

    //    public abstract void Display(); 
    //}

    //class B:A
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("This is display of B"); 
    //    }
    //} 
    #endregion

    abstract class Employee
    {
        public int EmpID { get; set; }
        public String Name { get; set; }
        public double salPerHour { get; set; }

        public virtual void Details()
        {
            Console.WriteLine("EmpID : " + EmpID);
            Console.WriteLine("Emp Name : " + Name);
            Console.WriteLine("Salary Per Hour : " + salPerHour);
        }

        public abstract void CalculateSalary(int NoOfWorkingHours);
        public abstract void CalculateLeave();

    }

    class softwareEng : Employee
    {
        public String Technology { get; set; }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("Technology : " + Technology);
        }

        public override void CalculateSalary(int NoOfWorkingHours)
        {
            double BS = (salPerHour * NoOfWorkingHours);
            double HRA = BS * 15 / 100;
            double GS = BS + HRA;
            Console.WriteLine("Gross Salary is : " + GS );
        }

        public override void CalculateLeave()
        {
            Console.WriteLine("This is Calculating leave of SE");
        }
    }

    class TeamLead : Employee
    {
        public int size { get; set; }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("sizey : " + size);
        }

        public override void CalculateSalary(int NoOfWorkingHours)
        {
            double BS = (salPerHour * NoOfWorkingHours);
            double HRA = BS * 30.5 / 100;
            double GS = BS + HRA;
            Console.WriteLine("Gross Salary of Teamlead is : " + GS);
        }

        public override void CalculateLeave()
        {
            Console.WriteLine("Calsulate leave of TL");
        }
    }


    public class Program
    {
        static void Main(String[] args)
        {
            Employee E;
            Console.WriteLine("1.SE 2.TL 3.HR");
            int type = int.Parse(Console.ReadLine());
            switch(type)
            {
                case 1:
                    E = new softwareEng() { EmpID = 100, Name = "Peter", salPerHour = 45, Technology = ".net core" };
                    break;

                case 2:
                    E = new TeamLead() { EmpID = 200, Name = "Jack", salPerHour = 46, size = 12 };
                    break;

                default:
                    E = new softwareEng() { EmpID = 100, Name = "Peter", salPerHour = 45, Technology = ".net core" };
                    break;

            }

            E.Details();
            E.CalculateSalary(36);
            E.CalculateLeave();

            Console.ReadLine();
        }
    }
}
