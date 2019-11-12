using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creating_Product_Dll;

namespace Creating_Product_Dll_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppu;
            int nou;
            double ba;

            Console.WriteLine("Enter Price Per Unit");
            ppu = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter No Of Unit");
            nou = int.Parse(Console.ReadLine());

            Product p = new Product();

            ba = p.GetBillAmount(ppu, nou);

            Console.WriteLine("Your bill Amount is " + ba);

            Console.ReadLine();
        }
    }
}
