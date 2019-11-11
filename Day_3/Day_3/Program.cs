using System;

namespace Day_3
{
    class Student
    {
        int _Sid;
        String _Name;

        public Student(int _Sid, String _Name)
        {
            this._Sid = _Sid;
            this._Name = _Name;
        }

        public int Sid
        {
            set { _Sid = value; }
            get { return _Sid; }
        }
        public String Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            var S = new Student(100, "Peter");

            Console.WriteLine("Student ID{0} Name{1}", S.Sid, S.Name);

            S.Name = "Piter";
            Console.WriteLine("Student ID{0} Name{1}", S.Sid, S.Name);  

            Console.ReadLine();
        }
    }
}
