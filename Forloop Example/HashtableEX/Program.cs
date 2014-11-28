using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("001", "Peter");
            ht.Add("002", "Sam");
            ht.Add("003", "Jhon");

            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine("{0}-{1}",k,ht[k]);

            }
            Console.ReadKey();
        }
    }
}
