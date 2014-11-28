using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Array_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            string s ;
            Console.WriteLine("Enter thename:");
            s = Console.ReadLine();
            s = RecursivelyReverseString(s);
            Console.WriteLine(s);
            Console.ReadLine();
            


        }
        public static string RecursivelyReverseString(string s)
        {
            if (s.Length > 0)
            {
                string x = s[s.Length - 1] + RecursivelyReverseString(s.Substring(0, s.Length - 1));
                return x;
            }
            else
                return s;
        }
    }
}
