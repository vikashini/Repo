using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternate_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.Write("Enter the total No of nodes:");
            int tot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the nodes in the list");
            for (int i = 0; i < tot; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list.add(num);
            }
            Console.WriteLine("==================");
            Console.WriteLine("Item in the list");
            Console.WriteLine("==================");
            list.printallnode();
            list.alternatesplit();
            //Console.WriteLine("The elements in list 2 are");
            //list.printallnode();
            Console.ReadLine();
        }
    }

    public class LinkedList
    {
        private Node head;
        private int count;
        private Node head1= null;
        private Node head2 = null;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int Count()
        {
            return this.count;
        }


        //Adding Node

        public int add(int index, int o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (index > count)
                index = count;

            Node current = this.head;

            if (isEmpty() || index == 0)
            {
                this.head = new Node(o);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;
                current.next = new Node(o);
            }

            count++;

            return 0;
        }

        public int add(int o)
        {
            return this.add(count, o);
        }

        public void alternatesplit()
        {
           int len = 0;
           Node oddhead = null;
           Node evenhead = null;
           Node odd = null;
           Node even = null;
           Node current = this.head;

            LinkedList l2 = new LinkedList();

           while (current != null)
           {
               if (len % 2 == 0)
               {
                   if (evenhead == null)
                   {
                       evenhead = current;
                       even = current;

                   }
                   else
                   {
                       even.next = current;
                       even = current;
                   }
               }
               else if (oddhead == null)
               {
                   l2.add(current.Data);
                      
                   oddhead = current;
                       odd = current;

               }
               else
               {
                   l2.add(current.Data);
                   odd.next = current;
                   odd = current;
               }
               len++;
               current = current.next;
           }
          

           if (even != null)
           {
               even.next = null;
           }
           if (odd != null)
           {
               odd.next = null;
           }
           Console.WriteLine("The elements in list 1");
            l2.printallnode();
            Console.WriteLine("The elements in list 2");
            printallnode();
        }



        public void printallnode()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.next;
            }

        }
    }
    public class Node
    {
        public Node next;
        private int data;

        public Node()
        {
            next = null;
            data = 0;
        }
        public Node(int data)
        {
            next = null;
            this.data = data;

        }
        public int Data
        {
            get { { return data; } }

        }
    }
}
