using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class Program
    {
         void print ( int a)
        {

            Console.WriteLine("Values:{0}", a);
        }
         void print(double a)
         {

             Console.WriteLine("Values:{0}", a);
         }
         void print(String a)
         {

             Console.WriteLine("Values:{0}", a);
         }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print(25);
            p.print(23.4);
            p.print("vikashini");
            Console.ReadLine();

        }
    }
}
