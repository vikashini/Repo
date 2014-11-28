using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Of_hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int numdiscs;
            Console.Write("Enter the number of discs: ");
            numdiscs = Convert.ToInt32(Console.ReadLine());
            tower(numdiscs, 1, 3, 2);
            Console.ReadLine();
        
        }
        static void tower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                tower(n - 1, from, other, to);
                Console.WriteLine("Move {0} from tower {1} to tower {2}", n, from, to);
                tower(n - 1, other, to, from);
            }
        }

    }
}

