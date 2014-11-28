using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    class Program
    {
        public void Add(int a,int b)
        {
            int Result;
            Result = a + b;
            Console.WriteLine("Result:{0}",Result);
        }

        public void mul(int a, int b)
        {
            int Result;
            Result = a * b;
            Console.WriteLine("Result:{0}", Result);
        }

        public void sub(int a, int b)
        {
            int Result;
            Result = a - b;
            Console.WriteLine("Result:{0}", Result);
        }

        public void div(int a, int b)
        {
            int Result;
            Result = a / b;
            Console.WriteLine("Result:{0}", Result);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the Number 1:");
            num1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the Number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.Add(num1, num2);
            p.mul(num1, num2);
            p.sub(num1, num2);
            p.div(num1, num2);

            Console.ReadLine();
        }
    }
}
