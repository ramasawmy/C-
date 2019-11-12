using BLL;
using System;

namespace Day_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var result = Calculate.Divide(15, 0);
                Console.WriteLine("Result is " + result);
            }
            catch (Exception E)
            {

                Console.WriteLine(E.Message);
            }

            Console.ReadLine();
        }
    }
}
