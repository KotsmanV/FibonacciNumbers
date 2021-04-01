using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    public class FiboNumbers
    {
        public static double FiboNext(double input)
        {
            double fOne=1;
            double fTwo=fOne;
            double fN=0;
            for (int i = 1; i <= input; i++)
            {
                fN = fOne + fTwo;
                fOne = fTwo;
                fTwo = fN;
            }
            return fN;
        }
    }
}
