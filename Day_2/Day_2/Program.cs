using System;

namespace Day_2
{
    //struct Student
    //{
    //    public int StudentId;
    //    public string StudentName;
    //    public double Avg;

    //    public void Details()
    //    {
    //        Console.WriteLine("StudentID :" + StudentId);
    //        Console.WriteLine("StudentName :" + StudentName);
    //        Console.WriteLine("Avg :" + Avg);
    //    }

    //}
    class Program
    {

        #region VAR & DYNAMIC PART 1
        //static void Add(int a, int b)
        //{
        //    Console.WriteLine(a+b);
        //}

        //static void Add(int a, double b)
        //{
        //    Console.WriteLine(a + b);
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region 1D Array
            //int[] myArray = new int[5];
            //myArray[0] = 56;
            //myArray[1] = myArray[2] = 78;
            //myArray[3] = myArray[0] + myArray[1];
            //myArray[4] = int.Parse(Console.ReadLine());

            //Console.WriteLine(myArray[0]);
            //Console.WriteLine(myArray[1]);
            //Console.WriteLine(myArray[2]);
            //Console.WriteLine(myArray[3]);
            //Console.WriteLine(myArray[4]);

            //Console.WriteLine("The Element are");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //Console.WriteLine("Enter all the 5 value");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The element are - FOREACH LOOP");
            //foreach (int k in myArray)
            //{
            //    Console.WriteLine(k);
            //}


            //int sum = 0;
            //foreach (int item in myArray)
            //{
            //    sum = sum + item; 
            //}

            //Array.Sort(myArray);
            //Array.Reverse(myArray); 
            //Console.WriteLine("The element are - AFTER SORTING");
            //foreach (int k in myArray)
            //{
            //    Console.WriteLine(k);
            //}

            ////Console.WriteLine("Sum of integer is " + sum);

            //Console.WriteLine("Index is " +Array.IndexOf(myArray,100));
            //Console.WriteLine("Location isc" +Array.IndexOf(myArray,100) +1); 
            #endregion

            #region 2D Array
            //int[,] my2dArray = new int[2, 3];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j  < 3; j++)
            //    {
            //        my2dArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //} 
            #endregion

            #region Struct & class
            //Student S;
            //S.StudentId = 1234;
            //S.StudentName = "steven";
            //S.Avg = 78.8;

            //Console.WriteLine("Student ID : " + S.StudentId);
            //Console.WriteLine("Student Name : " +S.StudentName);
            //Console.WriteLine("Student Avg : " +S.Avg);

            //Student[] SA = new Student[5];
            //Random R = new Random();

            //for (int i = 0; i < SA.Length; i++)
            //{
            //    SA[i].StudentId = i+1;
            //    SA[i].StudentName = Console.ReadLine();
            //    SA[i].Avg = R.NextDouble() * 100;
            //}

            //foreach (Student st in SA)
            //{
            //    st.Details();
            //}

            //Console.WriteLine("1st Division Student");
            //foreach (Student st in SA)
            //{
            //    if (st.Avg >=60)
            //    {
            //        Console.WriteLine(st.StudentId);
            //        Console.WriteLine(st.StudentName);
            //        Console.WriteLine(st.Avg);
            //    }

            //} 
            #endregion

            #region VAR & DYNAMIC PART 2
            //var x = "Steven";
            //var z = 10;
            //z = 45;

            //var x = new int[6,7];

            //dynamic x;

            //x = 67;

            //x = "steven";

            //Add(45,67);

            //Add(45, 67.8); 
            #endregion




            Console.ReadLine();

        }
    }
}
