using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Collection Class Part 1
//using System.Collections; 
#endregion

namespace Advance_OOPs_Concepts
{
    #region Protected Access part 1
    ////Base Class
    //class A
    //{
    //    private int x;
    //    public int y;
    //    protected int z;
    //}

    ////Drived class
    //class B:A   //class B inherite class A
    //{
    //    private int l;
    //    public int m;
    //    //protected int z;
    //    //public int y;

    //    public void show()
    //    {
    //        //can access m
    //        //can access l
    //        //can access y
    //        //can access y
    //        //cannot access x
    //        //can access z
    //    }
    //} 
    #endregion

    #region Base Key Word Part 1
    // class A
    //{
    //    public A()
    //    {
    //        Console.WriteLine("A's constructor with 0 param");
    //    }

    //    public A(int x)
    //    {
    //        Console.WriteLine("A's constructor with 1 param");
    //    }
    //}

    //class B:A
    //{
    //    public B():base(5)
    //    {
    //        Console.WriteLine("B's Constructor with 0 param");
    //    }

    //    public B(int x, int y )
    //    {
    //        Console.WriteLine("B's Constructor with 2 param");
    //    }
    //}

    //class C : B
    //{
    //    public C():base(2,4)
    //    {
    //        Console.WriteLine("C's Constructor with 0 param");
    //    }

    //    public C(int x)
    //    {
    //        Console.WriteLine("Cs constructor with 1 param");
    //    }
    //} 
    #endregion

    #region Method Overriding Part 1
    //class Student
    //{
    //    protected int Sid;
    //    protected String Name;
    //    protected String Standard;

    //    public Student()
    //    {
    //    }

    //    public Student(int Sid, String Name, String Standard)
    //    {
    //        this.Sid = Sid;
    //        this.Name = Name;
    //        this.Standard = Standard;

    //    }

    //    protected double Maths, Science, Social;

    //    public double _Maths
    //    {
    //        set { Maths = value; }
    //        get { return Maths; }
    //    }

    //    public double _Science
    //    {
    //        set { Science = value; }
    //        get { return Science; }
    //    }

    //    public double _Social
    //    {
    //        set { Social = value; }
    //        get { return Social; }
    //    }

    //    public void GetDetails()
    //    {
    //        Console.WriteLine("Sid : "+ Sid);
    //        Console.WriteLine("Name : " + Name);
    //        Console.WriteLine("Standard : " + Standard);
    //    }

    //    public void GetAvg()
    //    {
    //        Console.WriteLine("AVG is " + Math.Round(Maths + Science + Social) / 3.0,2);
    //    }

    //}

    //class NewStudent : Student
    //{
    //    protected String Contact;

    //    public NewStudent(int Sid, String Name, String Standard, String Contact)
    //    {
    //        this.Sid = Sid;
    //        this.Name = Name;
    //        this.Standard = Standard;
    //        this.Contact = Contact;

    //    }

    //    protected double English;

    //    public double _English
    //    {
    //        set { English = value; }
    //        get { return English; }
    //    }

    //    public void GetDivision()
    //    {
    //        double avg = (Maths + Science + Social + English) / 4.0;

    //        if (avg < 35)
    //        {
    //            Console.WriteLine("Fail");
    //        }
    //        else if (avg < 60)
    //        {
    //            Console.WriteLine("Pass");
    //        }
    //        else if (avg < 70)
    //        {
    //            Console.WriteLine("Passed in First Division");
    //        }
    //        else if (avg < 100)
    //        {
    //            Console.WriteLine("Passed in Dist");
    //        }
    //    }

    //} 
    #endregion

    #region Absteact Method Part 1
    //abstract class A
    //{
    //    public abstract void Show();

    //    public void Display()
    //    {
    //        Console.WriteLine("This is Display Method");
    //    }
    //}

    //class B : A
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("This is Show method");
    //    }
    //    public void View()
    //    {
    //        Console.WriteLine("This is View Methid ");
    //    }
    //} 
    #endregion

    #region Sealed Method Part 1
    //abstract class A
    //{
    //    public abstract void Show();

    //    public void Display()
    //    {
    //        Console.WriteLine("This is Display Method");
    //    }
    //}

    //sealed class B : A
    //{
    //    public override sealed void Show()
    //    {
    //        Console.WriteLine("This is Show method");
    //    }
    //    public void View()
    //    {
    //        Console.WriteLine("This is View Methid ");
    //    }
    //}

    ////class C : B
    ////{
    ////    public override void Show()
    ////    {
    ////        Console.WriteLine("This is Show of C");
    ////    }
    ////}

    //// NOTE CANNOT OVERRIDE METHOD THAT IS SEALED 
    #endregion

    #region Dynamic Polymorphism part 1
    //abstract class Employee
    //{
    //    protected int  EmpID;
    //    protected String  EmpName;
    //    protected double SalPerDay;

    //    public Employee(int EmpID, String EmpName, double SalPerDay)
    //    {
    //        this.EmpID = EmpID;
    //        this.EmpName = EmpName;
    //        this.SalPerDay = SalPerDay;

    //    }

    //    public virtual void Display()
    //    {
    //        Console.WriteLine("EmpID : " + EmpID);
    //        Console.WriteLine("EmpName : " + EmpName);
    //        Console.WriteLine("Emp Sal Per Day : "+ SalPerDay);
    //    }

    //    public abstract void CalculateSalary(int days);
    //}

    //class LabAssistant : Employee
    //{
    //    protected int LabNo;
    //    public LabAssistant(int EmpID, String EmpName, double SalPerDay, int LabNo):base(EmpID, EmpName,SalPerDay)
    //    {
    //        this.LabNo = LabNo;
    //    }

    //    public override void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("LabNo : " + LabNo);
    //    }

    //    public override void CalculateSalary(int days)
    //    {
    //        double GS = SalPerDay * days;
    //        Console.WriteLine("Gross Salary is : " + GS);
    //    }
    //}

    #endregion

    #region Interfaces Part 1
    //interface A
    //{
    //    void Show();
    //    void Display(String msg);
    //}

    //interface B
    //{
    //    void View();
    //}

    //class C : A,B
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("This is Show Method");
    //    }

    //    public void Display(String msg)
    //    {
    //        Console.WriteLine("This is Display of "+ msg);
    //    }

    //    public void View()
    //    {
    //        Console.WriteLine("This is View Method");
    //    }
    //} 
    #endregion

    #region Generic Collection Class Part 1
    //class Student
    //{
    //    int Sid;
    //    String Name;

    //    public Student(int Sid, String Name)
    //    {
    //        this.Sid = Sid;
    //        this.Name = Name;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("SID:{0} Name:{1}", Sid, Name);
    //    }

    //} 
    #endregion

        
    
    
    
    class Program
    {
        static void Main(string[] args)
        {

            #region Protected Access part 2
            //A a = new A();
            //// can access a.y;
            //// cannot access a.x;
            //// cannot access a.z;

            //B b = new B();
            ////Can access b.m;
            ////cannot access b.l;
            ////can access b.y;
            ////cannot access b.x;
            ////cannot access b.z;

            #endregion

            #region Base Key Word Part 2
            ////A a = new A();

            ////B b = new B();

            //C c = new C();


            //Console.ReadLine(); 
            #endregion

            #region Method OverRiding Part 2 
            //Student s = new Student(124, "Peter", "X");
            //s._Maths = 67;
            //s._Science = 78;
            //s._Social = 66;
            //s.GetDetails();
            //s.GetAvg();

            //NewStudent ns = new NewStudent(125, "Tom", "IX", "987654321");
            //ns._English = 77;
            //ns._Maths = 89;
            //ns._Science = 55;
            //ns._Social = 98;

            //ns.GetDetails();

            //Console.ReadLine(); 
            #endregion

            #region Abstract Mathod Part 2
            //A a;
            //B b = new B();

            //b.Display();
            //b.View();
            //b.Show();

            //Console.ReadLine(); 
            #endregion

            #region Sealed Method Part 2
            ////C c = new C();
            ////c.Show();

            //B b = new B();

            //Console.ReadLine(); 
            #endregion

            #region Dynamic Polymorphism Part 2
            //Employee e;
            //e = new LabAssistant(123, "Peter", 67.7, 34);
            //e.Display();
            //e.CalculateSalary(25);

            //Console.ReadLine(); 
            #endregion

            #region Interface Part 2
            ////C c = new C();
            ////c.Display("Peter");
            ////c.Show();
            ////c.View();

            //A a;
            //a = new C();
            //a.Display("Peter");
            //a.Show();
            ////a.View();

            //B b;
            //b = new C();
            //b.View();

            //Console.ReadLine(); 
            #endregion

            #region Collection Class Part 2
            //Stack s = new Stack();

            //s.Push(12);
            //s.Push(14);
            //s.Push(56);

            //Console.WriteLine("Element are");
            //foreach (int  item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Pop An Element ");
            //Console.WriteLine(s.Pop().ToString());

            //Console.WriteLine("Element After poping are");
            //foreach (int item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //int sum = 0;
            //foreach (int item in s)
            //{
            //    sum = sum + item;
            //}

            //Console.WriteLine("Sum is " + sum);

            //Queue q = new Queue();

            //q.Enqueue(23);
            //q.Enqueue(45);
            //q.Enqueue(56);


            //Console.WriteLine("Element are");
            //foreach (int item in q)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Dequeue An Element ");
            //Console.WriteLine(q.Dequeue().ToString());

            //Console.WriteLine("Element After Dequeue are");
            //foreach (int item in q)
            //{
            //    Console.WriteLine(item);
            //}

            //int sum = 0;
            //foreach (int item in q)
            //{
            //    sum = sum + item;
            //}

            //Console.WriteLine("Sum is " + sum);

            //Console.ReadLine(); 
            #endregion

            #region Generic Collection Class Part 2
            ////Stack<int> s = new Stack<int>();

            ////s.Push(23);
            ////s.Push(89);
            ////s.Push(34);

            ////Console.WriteLine(s.Pop());

            ////Queue<string> q = new Queue<string>();

            ////List<int> l = new List<int>();

            //List<Student> S = new List<Student>(5);

            //Student S1 = new Student(123, "Peter");
            //S.Add(S1);

            //Student S2 = new Student(124, "Jack");
            //S.Add(S2);

            //S.Add(new Student(125, "Tom"));
            //S.Add(new Student(126, "Lily"));
            //S.Add(new Student(127, "Bob"));

            //foreach (Student item in S)
            //{
            //    item.Display();
            //}

            //Console.ReadLine(); 
            #endregion



        }
    }
}
