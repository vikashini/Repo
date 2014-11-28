using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = {2,3,1,5,4};
            int a;
            for (int i = 0; i <number.Length; i++)
            {
                for (int j = i + 1; j <number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        a = number[i];
                        number[i] = number[j];
                        number[j] = a;
                    }
                }
            }
           
            for (int i = 0; i < number.Length; i++) 
            { 
                Console.WriteLine(number[i]);
            }
            Console.ReadLine();
        }
    }
}
