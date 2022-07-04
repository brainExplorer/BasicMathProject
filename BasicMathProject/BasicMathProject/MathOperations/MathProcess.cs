using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathProject.MathOperations
{
    internal class MathProcess : IMathProcess
    {
        public int? addition(int[] additioner) => additioner?.Sum();

        public int? division(int divisor1, int divisor2) => divisor1/divisor2;

        public int? multiply(int[] multiplier) => multiplier.Aggregate((mult, e) => mult * e);

        public int? subtract(int[] subtractor) => subtractor?.Aggregate((sub, s) => sub - s);
    }
}
