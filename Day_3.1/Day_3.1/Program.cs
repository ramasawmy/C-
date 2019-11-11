using System;
using System.ComponentModel.DataAnnotations;

namespace Day_3._1
{
    #region Propertiess
    //class Student
    //{
    //    [Required]
    //    public int Sid { get; set; }

    //    [Required]
    //    [MaxLength(50, ErrorMessage = "Max length should be 50")]
    //    public String Name { get; set; }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var S = new Student();
    //        S.Sid = 100;
    //        S.Name = "Peter";
    //        Console.WriteLine("Student ID:{0} Name:{1}", S.Sid, S.Name);

    //        var S1 = new Student() { Sid = 200, Name = "Piter" };
    //        Console.WriteLine("Student ID:{0} Name:{1}", S1.Sid, S1.Name);

    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region Static
    //class Program
    //{
    //    class HousingLoanCustomer
    //    {
    //        int CustomerID;
    //        String Name;
    //        double LoanAmount;
    //        static double _ROI;

    //        public static double ROI
    //        {
    //            set{ _ROI = value; }
    //            get { return _ROI; }
    //        }

    //        static HousingLoanCustomer()
    //        {
    //            _ROI = 11.2;
    //        }

    //        public HousingLoanCustomer(int CustomerID, String Name, double LoanAmount)
    //        {
    //            this.CustomerID = CustomerID;
    //            this.Name = Name;
    //            this.LoanAmount = LoanAmount;

    //        }

    //        public void CalculateInterest(int month ) 
    //        {
    //            double IntAmount = LoanAmount * _ROI / 100;
    //            double RepayAmount = LoanAmount + IntAmount;
    //            Console.WriteLine("Laon amount:{0} IntAmount:{1} RepayAmunt:{2} ROI:{3}", LoanAmount,IntAmount, RepayAmount, _ROI);
    //            Console.WriteLine("EMI:" + (RepayAmount / month));

    //        }

    //        public static void Enquiry(double EnLoanAmount, int month)
    //        {
    //            Console.WriteLine("ROI :" + ROI);
    //            Console.WriteLine("Loan Amount :" + EnLoanAmount);
    //            Console.WriteLine("IntAmount :" + EnLoanAmount * ROI / 100);
    //            Console.WriteLine("RepayAmount :" + (EnLoanAmount + (EnLoanAmount * ROI / 100)));
    //            Console.WriteLine("EMI Month :" + month);
    //            Console.WriteLine("EMI :" +(EnLoanAmount + (EnLoanAmount * ROI / 100)) / month);

    //        }


    //    }

    //    static void Main(string[] args)
    //    {
    //        //var laonCustomer1 = new HousingLoanCustomer(1, "peter", 75000);
    //        //laonCustomer1.CalculateInterest(12);

    //        //var laonCustomer2 = new HousingLoanCustomer(2, "Jack", 85000);
    //        //laonCustomer2.CalculateInterest(24);


    //        //HousingLoanCustomer.ROI = 11.5;

    //        //laonCustomer1.CalculateInterest(12);
    //        //laonCustomer2.CalculateInterest(24);

    //        //HousingLoanCustomer.Enquiry(60000, 24);



    //        Console.ReadLine();           
    //    }
    //} 
    #endregion


    //class Calculation
    //{
    //    public static void Add(int a, int b)
    //    {
    //        Console.WriteLine("Addition is " + (a + b));
    //    }
    //    public static void Multiply(int a, int b)
    //    {
    //        Console.WriteLine("Multiplication is " + (a * b));
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter value for a:");
    //        int a = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter value for b:");
    //        int b = int.Parse(Console.ReadLine());
            
    //        Calculation.Add( a, b);

    //        Calculation.Multiply(a, b);
            

    //        Console.ReadLine();
    //    }
    //}


}
