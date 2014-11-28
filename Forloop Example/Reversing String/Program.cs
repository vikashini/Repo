using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            int i;
            Console.WriteLine("Enter thename:");
            Name = Console.ReadLine();

            char[] Temp = Name.ToCharArray();
            
            Reverse(Temp);
            Console.ReadLine();
        }

        static void swap(int firstposition, int secondposition, char[] Temp)
        {
            
            char var = Temp[firstposition];
            Temp[firstposition] = Temp[secondposition];
            Temp[secondposition] = var;

            
        }
       static void Reverse(char[] temp)
        {
            for (int i = 0; i < temp.Length/2; i++)
            {
                int x = temp.Length - i - 1;

                swap(i,x,temp);
            }

            for (int j = 0; j < temp.Length; j++)
            {
                Console.WriteLine("The String is : {0}", temp[j]);
            }

        }
    }
}
