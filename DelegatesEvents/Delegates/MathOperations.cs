using System;

namespace Delegates
{
    class MathOperations
    {
        public delegate void MenimVekilim();

        public event MenimVekilim MenimDBLEventim;





        public void Sum(int a, int b)
        {
            if (MenimDBLEventim != null)
            {
                MenimDBLEventim();
                Console.WriteLine("Sum: " + (a + b));
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }

        }
        public void Subtract(int a, int b)
        {
            if (MenimDBLEventim != null)
            {
                MenimDBLEventim();
                Console.WriteLine("Subtract: " + (a - b));

            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
        public void Multiply(int a, int b)
        {
            if (MenimDBLEventim != null)
            {
                MenimDBLEventim(); Console.WriteLine("Multiply: " + (a * b));

            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
        public void Divide(int a, int b)
        {
            if (MenimDBLEventim != null)
            {
                MenimDBLEventim(); Console.WriteLine("Divide: " + (a / b));

            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
    }
}
