using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Operation
    {
        MathOperations math;
        public int operant1 { get; set; }
        public int operant2 { get; set; }

        public Operation(int a, int b)
        {
            math = new MathOperations();
            math.MenimDBLEventim += MenimYeniMetodum;
            operant1 = a;
            operant2 = b;

        }


        public void MenimYeniMetodum()
        {
            Console.WriteLine("MathOperations methodlardan biri ishe dushdu");
        }

        public void SumOp()
        {
            math.Sum(operant1, operant2);
        }
        public void SubOp()
        {
            math.Subtract(operant1, operant2);
        }
        public void DivideOp()
        {
            math.Divide(operant1, operant2);
        }
        public void MulOp()
        {
            math.Multiply(operant1, operant2);
        }
    }
}
