using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        public delegate void MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            //String test1 = "Murad";

            //String test = test1;

            //test1 = "Rauf";
            //Console.WriteLine(test1);
            //Console.WriteLine(test);

            //MathOperations mo = new MathOperations();
            //MyDelegate myDelegate = mo.Sum;
            //myDelegate += mo.Subtract;
            //myDelegate += mo.Divide;
            //myDelegate -= mo.Subtract;
            //myDelegate += mo.Multiply;

            //myDelegate(100,50);

            //TestMethod(mo.Sum, 10, 5);


            Console.WriteLine("Events ========");

            Operation operation = new Operation(20, 5);
            operation.SumOp();
            operation.SubOp();
            operation.DivideOp();
            operation.MulOp();
            



            Console.Read();
        }

        //static void TestMethod(MyDelegate dele, int a, int b)
        //{
        //    dele(a, b);
        //}
    }
}
