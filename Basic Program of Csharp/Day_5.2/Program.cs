using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5._2
{
    #region Structure part 1
    //struct Student
    //{
    //    public int Sid;
    //    public String Name;
    //    public double Avg;
    //} 
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Arithmatic operation
            //int n1, n2, n3;

            //Console.WriteLine("Enter the value of n1:");
            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the value of n2:");
            //n2 = int.Parse(Console.ReadLine());

            //n3 = n1 + n2;

            //Console.WriteLine("Sum of {0} and {1} is {2}", n1, n2, n3);
            //Console.WriteLine("Sum of " + n1 + " and " + n2 + " is " + n3 );  

            //Console.ReadLine(); 
            #endregion

            #region Type conversion of Type casting
            //int a = 5;
            //int b = 2;

            //Console.WriteLine((double) a/b);
            //Console.ReadLine(); 
            #endregion

            #region if else implementation
            //int a = 78;
            //int b = 145;

            //if (a > b)
            //{
            //    Console.WriteLine("GReater is " + a);
            //}
            //else
            //{
            //    Console.WriteLine("Greater is " + b);
            //}

            //Console.ReadLine(); 
            #endregion

            #region else if ladder
            //int a = 64;
            //int b = 78;
            //int c = 67;
            //int d = 678;

            //if (a > b && a > c && a > d)
            //    Console.WriteLine("Greater is " + a);
            //else
            //{
            //    if (b > a && b > c && b > d)
            //        Console.WriteLine("Greater is " + b);
            //    else
            //    {
            //        if (c > a && c > b && c > d)
            //            Console.WriteLine("Greater is " + c);
            //        else
            //        {
            //            if (d > a && d > b && d > d)
            //                Console.WriteLine("Greater is " + d);
            //        }
            //    }
            //}

            //if (a > b && a > c && a > d)
            //    Console.WriteLine("Greater is " + a);
            //else if (b > a && b > c && b > d)
            //    Console.WriteLine("Greater is " + b);
            //else if (c > a && c > b && c > d)
            //    Console.WriteLine("Greater is " + c);
            //else if (d > a && d > b && d > c)
            //    Console.WriteLine("Greater is " + d);
            //Console.ReadLine(); 
            #endregion

            #region Switch Case Default
            //int a = 45;
            //int b = 34;

            //Console.WriteLine("+.Add -.Sub *.Mul /.Div");

            //String ch = Console.ReadLine();

            //switch(ch)
            //{
            //    case "+":
            //        Console.WriteLine(a+b);
            //        break;

            //    case "-":
            //        Console.WriteLine(a - b);
            //        break;

            //    case "*":
            //        Console.WriteLine(a * b);
            //        break;

            //    case "/":
            //        Console.WriteLine(a / b);
            //        break;


            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}
            //Console.ReadLine(); 
            #endregion

            #region For Loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Steven");
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >=1 ; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);   
            //}

            //int n = 6;

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("(0) * (1) = (2)", n, i, n*i);
            //}

            //Console.ReadLine(); 
            #endregion

            #region While Loop
            //int i = 10;
            //while (i <10)
            //{
            //    Console.WriteLine("Steven");
            //    i++;
            //}

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int r;
            //while (n !=0)
            //{
            //    r = n * 10;
            //    sum = sum + r;
            //    n = n / 10;
            //}
            //Console.WriteLine("Sum is " + sum);
            //Console.ReadLine(); 
            #endregion

            #region Do While Loop
            //int n;
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //}
            //while (n != 0);

            //Console.WriteLine("You have enter " +  n); 
            #endregion

            #region Arrays
            //int[] A;
            //A = new int[10];

            //A[0] = 67;
            //A[1] = A[2] = A[3] = 56;
            //A[4] = A[1] + A[2] + A[3];
            //A[5] = A[6] = A[7] = A[4] - 10;
            //A[8] = A[9] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}
            //Console.ReadLine(); 
            #endregion

            #region Arrays and ForEach Loop
            //int[] A = new int[5];

            //Console.WriteLine("Enter 5 element");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Element that you enter are :");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //Array.Sort(A);
            //Array.Reverse(A);

            //Console.WriteLine("Element that you sorted are:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //int sum = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    sum = sum * A[i];
            //}
            //Console.WriteLine("Sum is " + sum);

            ////foreach (int  k in A)
            ////{
            ////    if (k % 2 == 0) 
            ////    Console.WriteLine(k);
            ////}

            //Console.ReadLine(); 
            #endregion

            #region Structure part 2
            //Student s;

            //s.Sid = 1234;
            //s.Name = "Steven";
            //s.Avg = 88.9;

            //Console.WriteLine("Sid: " + s.Sid);
            //Console.WriteLine("Name: " + s.Name);
            //Console.WriteLine("AVG: " + s.Avg);

            //Student[] s = new Student[5];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine("Enter Sid");
            //    s[i].Sid = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Name");
            //    s[i].Name = Console.ReadLine();

            //    Console.WriteLine("Enter Avg");
            //    s[i].Avg = double.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Student(s) who secured more than 80%");
            //foreach (Student k in s)
            //{
            //    if (k.Avg >= 80) 
            //    {
            //        Console.WriteLine("Record");
            //        Console.WriteLine("Sid: " + k.Sid);
            //        Console.WriteLine("Name: " + k.Name);
            //        Console.WriteLine("Avg: " + k.Avg);
            //    }

            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine("Record");
            //    Console.WriteLine("Sid: " + s[i].Sid);
            //    Console.WriteLine("Name: " + s[i].Name);
            //    Console.WriteLine("Avg; " + s[i].Avg);
            //}
            //Console.ReadLine(); 
            #endregion


        }
    }
}
