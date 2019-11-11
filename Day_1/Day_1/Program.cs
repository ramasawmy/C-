using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Day_1=Intro
            //int a, b, c;
            //a = 10;
            //b = 20;
            //c = a + b;

            //Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);

            //Console.WriteLine("The sum of " + a + " and " + b + " is " + c);

            //int a, b, c;    
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse("45");
            //c = a + b;

            //Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);

            //Console.WriteLine("The sum of " + a + " and " + b + " is " + c); 
            #endregion

            //Dim i as interger; (VB.net)
            //Dim i as System.Int32; (VB.net)

            //int i; (c#)
            //System.Int32 i; (c#)

            //IF STATEMENT(><)
            //int a = 10;
            //int b = 20;
            //if (a>b) 
            //{
            //    Console.WriteLine("{0} is greater", a);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is greater", b);
            //}

            //NESTED Effect(><)
            //int a = 10;
            //int b = 20;
            //int c = 6;
            //int d = 56;

            //(PART_1><)
            //if (a > b && a>c && a>d)
            //{
            //    Console.WriteLine("{0} is greater", a);
            //}
            //else
            //{
            //    if (b>a && b>c && b>d)
            //    {
            //        Console.WriteLine("{0} is greater", b);
            //    }
            //    else
            //    {
            //        if(c>a && c>b && c>d)
            //        {
            //            Console.WriteLine("{0} is greater", c);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} is greater", d);
            //        }
            //    }

            //}

            //(PART_2><)
            //if (a > b && a > c && a > d)
            //{
            //    Console.WriteLine("{0} is greater", a);
            //}
            //else if (b>a && b>c && b>d)
            //{
            //    Console.WriteLine("{0} is greater", b);
            //}
            //else if (c>a && c>b && c>d)
            //{
            //    Console.WriteLine("{0} is greater", c);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is greater", d);
            //}

            //Switch_Case(><)
            //int a = 10;
            //int b = 20;

            //int opt;

            //L: Console.WriteLine("1.Add 2.Mul 3.Sub 4.Exit");
            //opt = int.Parse(Console.ReadLine());

            //switch (opt)
            //{
            //    case 2:
            //        Console.WriteLine("Multiplicaion is" + a * b);
            //        break;
            //    case 1:
            //        Console.WriteLine("Addition is" + (a + b));
            //        break;
            //    case 3:
            //        Console.WriteLine("Subtraction is" + (a - b));
            //        break;
            //    case 4:
            //        break;
            //    default:
            //        Console.WriteLine("Invalid option !");
            //        goto L;
            //}

            //FOR LOOP(><)
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Welcome to Checkout !");
            //}

            ////6 * 1 = 6
            ////6 * 2 = 12
            ////INCREMENT VALUE
            //int n = 6;
            //for (int i = 1; i <=10 ; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            //}

            //Console.WriteLine("");
            ////DECREMENT VALUE
            ////int n = 6;
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            //}

            //WHILE LOOP(><)
            //int n = 2367;

            //LOGICAL FOR WHILE LOOP(><)
            //sum=10
            //r=n%10 =7
            //sum =sum +r =7
            //n=n/10 =236

            //r=n%10 =6
            //sum =sum +r =13
            //n=n/10 =23

            //r=n%10 =3
            //sum =sum +r =16
            //n=n/10 =2

            //r=n%10 =2
            //sum =sum +r =18
            //n=n/10 =0

            //int sum = 0;
            //int r = 0;
            //while (n!=0)
            //{
            //    r = n % 10;
            //    sum = sum + r;
            //    n = n / 10;

            //}
            //Console.WriteLine("Sum is "+sum);

            //DO WHILE LOOP(><)
            //IN DO WHILE LOOP THERE IS ; AT THE END
            //int i;
            //do
            //{
            //    i = int.Parse(Console.ReadLine());
            //} while (i != 0);

            //INFINITE LOOP(><)
            //for (; ;)
            //{
            //    Console.Write("Welcome to Checkout !");
            //}

            //while (true)
            //{
            //    Console.Write("Welcome to Checkout !");
            //}


            //Console.ReadLine();
        }
    }
}
