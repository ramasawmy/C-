using System;

namespace BLL
{
    public class Calculate
    {
        public static double Divide(int a, int b)
        {
            try
            {
                if (b !=0)
                {
                    return a / b;
                }
                else
                {
                    return 0;
                }
            }
            
            catch(Exception E)
            {
                throw new Exception("Invalid second param or b value cannot be zero");


            }

        }
    }
}
