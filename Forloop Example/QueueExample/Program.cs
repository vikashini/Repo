using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue('V');
            q.Enqueue('I');
            q.Enqueue('K');
            q.Enqueue('A');

            Console.WriteLine("Current queue: ");
            foreach (char c in q)
                Console.Write(c + " ");
            Console.WriteLine();
            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current queue: ");
            foreach (char c in q)
                Console.Write(c + " ");
            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            foreach (char c in q)
            Console.Write(c + " ");
            Console.WriteLine();
            //Console.WriteLine("The removed value: {0}", ch);
            //ch = (char)q.Dequeue();
            //Console.WriteLine("The removed value: {0}", ch);
            Console.ReadKey();
        }
    }
}
