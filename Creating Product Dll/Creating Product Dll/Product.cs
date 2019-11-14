using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Product_Dll
{
    public class Product
    {
        public double  GetBillAmount(int PricePerUnit, int NoOfUnits)
        {
            double amt;
            amt = PricePerUnit * NoOfUnits;
            return amt;

        }

    }
}
