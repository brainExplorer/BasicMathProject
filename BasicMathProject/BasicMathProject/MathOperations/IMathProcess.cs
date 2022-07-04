using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathProject.MathOperations
{
    internal interface IMathProcess
    {       
         int? multiply(int[] multiplier);
         int? division(int divisor1, int divisor2);
         int? addition(int[] additioner);
         int? subtract(int[] subtractor);
    }

    internal interface INumbers
    {
         int? getNumbers(int[] ints, string processName);
    }
}


