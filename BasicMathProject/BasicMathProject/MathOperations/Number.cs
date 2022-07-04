using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathProject.MathOperations
{
    internal class Number : INumbers
    {
        public readonly IMathProcess _process;
        public Number()
        {
            _process = new MathProcess();
        }
        public Number(IMathProcess process)
        {
            _process = process;
        }
        public int? getNumbers(int[] ints, string processName) => processName=="*" ? _process.multiply(ints): 
                                                                                processName=="+" ? _process.addition(ints): 
                                                                                processName=="/" ? _process.division(ints[0], ints[1]) : _process.subtract(ints);
    }
}

