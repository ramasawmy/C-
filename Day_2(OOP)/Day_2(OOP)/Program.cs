using System;

namespace Day_2_OOP_
{
    class Student
    {
        #region oop_1
        //int Sid;
        //string Name;
        //double M1, M2;

        //public void CreateStudent(int id,String name)
        //{
        //    Sid = id;
        //    Name = name;
        //}
        //public void SetMarks(double m1, double m2)
        //{
        //    M1 = m1;
        //    M2 = m2;
        //}
        //public void Result()
        //{
        //    double avg = (M1 + M2) / 2;
        //    if (avg >=35)
        //    {
        //        Console.WriteLine("Pass");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fail");
        //    } 
        #endregion

        #region oop_2
        //int Sid;
        //string Name;
        //double M1, M2;

        //public Student()
        //{
        //    Console.WriteLine("This is a default contructor");
        //}

        //public Student(int id, String name)
        //{
        //    Sid = id;
        //    Name = name;
        //}
        //public void SetMarks(double m1, double m2)
        //{
        //    M1 = m1;
        //    M2 = m2;
        //}
        //public void Result()
        //{
        //    double avg = (M1 + M2) / 2;
        //    if (avg >= 35)
        //    {
        //        Console.WriteLine("Pass");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fail");
        //    }
        //}
        #endregion

        #region oop_3
        //int Sid;
        //string Name;
        //double M1, M2;
        //string Contact;

        //public Student()
        //{
        //    Console.WriteLine("This is a default contructor");
        //}

        //public Student(int Sid, String Name)
        //{
        //   this.Sid = Sid;
        //    this.Name = Name ;
        //}

        //public Student(int Sid, String Name, string Contact):this(Sid,Name)
        //{
        //    //this.Sid = Sid;
        //    //this.Name = Name;
        //    this.Contact = Contact;
        //}
        //public void SetMarks(double M1, double M2)
        //{
        //    this.M1 = M1;
        //    this.M2 = M2;
        //}

        //public void GetDetails()
        //{
        //    Console.WriteLine("StudentID:{0} Name {1} Contact{2}",Sid,Name,Contact);
        //}

        //public void Result()
        //{
        //    double avg = (M1 + M2) / 2;
        //    if (avg >= 35)
        //    {
        //        Console.WriteLine("Pass");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fail");
        //    }
        //}

        //public void Result(double minAvgToPass)
        //{
        //    double avg = (M1 + M2) / 2;
        //    if (avg >= minAvgToPass)
        //    {
        //        Console.WriteLine("Pass");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fail");
        //    }
        //} 
        #endregion

        int Sid;
        string Name;

        public Student(int Sid, String Name)
        {
            this.Sid = Sid;
            this.Name = Name;
        }

        public int GetSid()
        {
            return Sid;
        }
        public String GetName()
        {
            return Name;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            #region opp_1
            //Student S;
            //S = new Student();

            //Console.WriteLine("Enter Student ID and Name");
            //int id = int.Parse(Console.ReadLine());
            //String name = Console.ReadLine();

            //S.CreateStudent(id, name); //initialize object Explicitly -- issue 1

            //Console.WriteLine("Enter Marks 1 and 2");
            //double m1 = double.Parse(Console.ReadLine());
            //double m2 = double.Parse(Console.ReadLine());

            //S.SetMarks(m1, m2);

            //S.Result();

            ////RE-initialize the object ----issue 2
            //S.CreateStudent(200, "Steven");


            //Console.ReadLine(); 
            #endregion

            #region OOP_2
            //Student S1 = new Student(200, "Steven");



            //Student S = new Student(100, "Peter");

            //S.SetMarks(23, 45);
            //S.Result();
            #endregion

            #region OPP_3
            //var S = new Student(100,"Steven","123456");

            ////var S1 = new Student(100, "peter");

            //S.GetDetails();
            //S.SetMarks(67, 78);
            //S.Result(); 
            #endregion

            var S = new Student(100, "Steven");

            int Sid = S.GetSid();
            String Name = S.GetName();
            Console.WriteLine("Sid:{0} Name{1}", Sid,Name);
           
            //Console.BackgroundColor = ConsoleColor.Blue;

            Console.ReadLine();


        }
    }
}
