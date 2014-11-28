using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.add(11);
            list.add(12);
            list.add(13); 
            Console.WriteLine("==================");
            Console.WriteLine("Item in the list");
            Console.WriteLine("==================");
          
            list.printallnode();

            Console.WriteLine("========================");
            Console.WriteLine("Removing Item Form List");
            Console.WriteLine("========================");
            Console.WriteLine("Enter the index(starting 0) of the item to be removed");
            
            int temp = Convert.ToInt32(Console.ReadLine());
            list.remove(temp);
            list.printallnode();

            Console.WriteLine("==========================");
            Console.WriteLine("Adding Item in front List");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter the value to be add in the front of the list:");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            list.addfront(temp1);
            list.printallnode();

            Console.WriteLine("==========================");
            Console.WriteLine("Adding Item in end List");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter the value to be add in the end of the list:");
            int temp2 = Convert.ToInt32(Console.ReadLine());
            list.addend(temp2);
            list.printallnode();

            Console.WriteLine("==========================");
            Console.WriteLine("Reversing List Loop");
            Console.WriteLine("==========================");
            list.Reverseloop();
            list.printallnode();
            Console.ReadLine();
       }
    }
}

