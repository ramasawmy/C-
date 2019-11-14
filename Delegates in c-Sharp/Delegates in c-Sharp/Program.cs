using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_in_c_Sharp
{
    #region DelegatePart 1.5
    //delegate void Test(String name);

    //class sample
    //{
    //    Test t1;

    //    public void CallBack(Test t1)
    //    {
    //        this.t1 = t1;
    //        t1("Peter");
    //    }
    //} 
    #endregion


    class Program
    {
        #region Delegate Part 1
        //delegate void Test(String name); 
        #endregion

        #region Delegate Part 2
        //static void Main(string[] args)
        //{
        //    Test t = new Test(Show);
        //    //t.Invoke("Peter");
        //    //t("Peter);

        //    t += new Test(Display);
        //    t += new Test(Display);
        //    t += new Test(Display);

        //    t("Peter");            

        //    Console.ReadLine();
        //}

        //static void Show(String name)
        //{
        //    Console.WriteLine("Show Hello " + name);
        //}

        //static void Display(String name)
        //{
        //    Console.WriteLine("Display Hello " + name);
        //} 
        #endregion

        #region Delegate Part 2.5
        //static void Main(string[] args)
        //{
        //    //Show("Peter");

        //    Test t = new Test(Display); // can replay display to schow


        //    //t("Peter");

        //    sample s = new sample();
        //    s.CallBack(t);




        //    Console.ReadLine();

        //}

        //static void Show(String name)
        //{
        //    Console.WriteLine("Show hello " + name);
        //}

        //static void Display(String name)
        //{
        //    Console.WriteLine("Display hello " + name);
        }
    #endregion

    
    }

}

