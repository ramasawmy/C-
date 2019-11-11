using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre your current meter reading !");
            
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your previous meter reading !");
            int b;
            b = int.Parse(Console.ReadLine());

            int c;
            c = a - b;
            //Console.WriteLine("Current unit is " + a + " Previous unit " + b + " is " + c);
            Console.WriteLine("Difference between current {0} and Previous {1} is {2}", a,b,c);


            int opt;
            L: Console.WriteLine("1.Domestic 2.Non Domestic 3.Exit");
            opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:

                    if (c>0 && c <= 200)
                    {
                        Console.WriteLine("Bill amount is " + (c*5) );
                    }    
                    else if (c>201 && c<=300)
                    {
                        Console.WriteLine("Bill amount is " + (c * 7.2));
                    }
                    else if (c>301 && c<=400)
                    {
                        Console.WriteLine("Bill amount is " + (c * 8.5));
                    }
                    else if (c>401 && c<=800)
                    {
                        Console.WriteLine("Bill amount is " + (c * 9));
                    }
                    else if (c>800)
                    {
                        Console.WriteLine("Bill amount is " + (c * 9.5));
                    }
                    else
                    {
                        Console.WriteLine("Invalid value");
                    }
                    break;

                case 2:


                    break;



                            

                default:
                    break;
            }






            Console.ReadLine();
        }
    }
}
