using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getnset_example
{
    class access
   {
     
     private static string name;
     public void print()
      {
        Console.WriteLine("\nMy name is " + name);
      }
 
    public string Name 
      {
        get 
         {
           return name;
         }
        set 
         {
           name = value;
         }
      }
   }
    
  class Program
   {
     static void Main(string[] args)
      {
        access ac = new access();
        Console.Write("Enter your name:");
        ac.Name = Console.ReadLine();
        ac.print();
        Console.ReadLine();
      }
   }
}
   